using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SceneSwitch());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SceneSwitch()
    {
        yield return new WaitForSeconds(16f);
        Debug.Log("Scene loaded..");
        SceneManager.LoadScene("Menu");
    }

    
}
