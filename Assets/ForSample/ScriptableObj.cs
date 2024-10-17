using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName ="SampleObj")]
public class ScriptableObj : ScriptableObject
{
    public UnityAction onEventRaised;
    public event Action onEventRaisedAction;

    public void RaiseEvent()
    {
        if(onEventRaised != null)
        {
            onEventRaised.Invoke();
        }

        onEventRaisedAction?.Invoke();
    }
}
