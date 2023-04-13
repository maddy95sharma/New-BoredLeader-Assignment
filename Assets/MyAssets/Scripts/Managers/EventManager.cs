using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public static event Action<int> CharcClickAction;
    public static event Action CardClickAction;
    public static event Action CharcPanelAction;

    // Detect character button click
    public static void RaisCharcEvent(int charcIdx)
    {
        CharcClickAction?.Invoke(charcIdx);
    }

    // Detect Card button click
    public static void RaisCardEvent()
    {
        CardClickAction?.Invoke();
    }

    // To disable panel
    public static void RaisPanelEvent()
    {
        CharcPanelAction?.Invoke();
    }
 

}
