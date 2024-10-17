using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "ColorObj")]
public class ColorObject : ScriptableObject
{
    public UnityAction onEventRaised;

    public void RaiseEvent()
    {
        if(onEventRaised != null)
        {
            onEventRaised.Invoke();
        }
    }
}
