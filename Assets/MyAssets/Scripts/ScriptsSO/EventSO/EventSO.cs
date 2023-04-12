using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "CardClickSO", menuName ="ScriptableObject/Event/EventSO")]
public class EventSO : ScriptableObject
{
    public UnityAction CardClickEvent;

    public void RaisEvent()
    {
        if(CardClickEvent != null) CardClickEvent.Invoke();
	}
}
