using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This class Triggers an event when dice in clicked
namespace BoredLeaders
{
    public class DiceClicked : MonoBehaviour
    {
        public static event Action DiceClickEvent;
        private Button btn;
        
        // Subscribe OnDiceClicked to button click event
        void Start()
        {   
            btn = GetComponentInChildren<Button>();
            btn.onClick.AddListener(() => OnDiceClicked());
        }

        // Triggers DiceClickEvent event
        void OnDiceClicked()
        {   
            DiceClickEvent.Invoke();
        }
    }

}
