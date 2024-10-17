using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{
    public GameObject objectToSpawn;
    public FreeLookCamera freeLookCamera;

    public void SpawnObject()
    {
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        freeLookCamera.SetTarget(spawnedObject.transform);
    }
}
