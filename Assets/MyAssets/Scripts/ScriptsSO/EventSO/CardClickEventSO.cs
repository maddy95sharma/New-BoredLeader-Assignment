using System;
using UnityEngine;
// using UnityEngine.Events;

[CreateAssetMenu(fileName = "CardClickEventSO", menuName ="ScriptableObject/Event/CardClickEventSO")]

public class CardClickEventSO : ScriptableObject
{
    public event Action CardClickEvent;

    public void RaisEvent(){
        CardClickEvent?.Invoke();
    }
}
