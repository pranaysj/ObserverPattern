using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController
{
    public event Action baseEvent;

    public void AddListener(Action action) => baseEvent += action;
    public void RemoveListener(Action action) => baseEvent -= action;
    public void InvokeEvent() => baseEvent?.Invoke();
}
