using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    // Detect character button click
    public static class CharcClickEvent
    {
        public static event Action<int> CharcClickAction;

        public static void RaisEvent(int charcIdx)
        {
            CharcClickAction?.Invoke(charcIdx);
        }
    }

    // Detect Card button click
    public static class CardClickEvent
    {
        public static event Action CardClickAction;

        public static void RaisEvent()
        {
            CardClickAction?.Invoke();
        }
    }

    // To disable panel
    public static class CharcPanelEvent
    {
        public static event Action CharcPanelAction;

        public static void RaisEvent()
        {
            CharcPanelAction?.Invoke();
        }
    }

}
