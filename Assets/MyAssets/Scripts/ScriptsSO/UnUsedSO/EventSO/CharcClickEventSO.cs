using System;
using UnityEngine;
// using UnityEngine.Events;

[CreateAssetMenu(fileName = "CharcClickEventSO", menuName ="ScriptableObject/Event/CharcClickEventSO")]

public class CharcClickEventSO : ScriptableObject
{
    public event Action CharcClickEvent;

    public void RaisEvent()
    {
        CharcClickEvent?.Invoke();
	}
}