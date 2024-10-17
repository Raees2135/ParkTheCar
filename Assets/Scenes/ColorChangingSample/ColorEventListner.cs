using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColorEventListner : MonoBehaviour
{
    public ColorObject colorObject;
    public UnityEvent response;

    public void OnEnable()
    {
        colorObject.onEventRaised += Raise;
    }

    public void OnDisable()
    {
        colorObject.onEventRaised -= Raise;
    }

    public void Raise()
    {
        response.Invoke();
    }
}
