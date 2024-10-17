using System.Collections;
using System;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    GameManager gameManager;

    public static event Action onLevelComplete;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.color = Color.green;

        yield return new WaitForSeconds(1.5f);

        if(renderer.material.color == Color.green)
        {
            onLevelComplete?.Invoke();
        }
    }
}
