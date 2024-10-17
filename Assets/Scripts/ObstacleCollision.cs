using System;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public static event Action onLevelFailed;
  
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "obstacle")
        {
            onLevelFailed?.Invoke();
        }
    }
}
