using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventListner : MonoBehaviour
{
    public ScriptableObj scriptableObj;
    public UnityEvent response;
    public Action action;

    public SpriteChange change;

    void OnEnable()
    {
        scriptableObj.onEventRaised += Raise;
        action += change.ChangeSprite;
    }

    void OnDisable()
    {
        scriptableObj.onEventRaised -= Raise;
        action -= change.ChangeSprite;
    }

    public void Raise()
    {
        response.Invoke();
    }

    public void ActionRaise()
    {
        action?.Invoke();
    }
}
