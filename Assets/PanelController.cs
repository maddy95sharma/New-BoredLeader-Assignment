using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Disable character panel
// Created by: Madhusudan
namespace BordLeaders
{
    public class PanelController : MonoBehaviour
    {
        void OnEnable()
        {
            EventManager.CharcPanelEvent.CharcPanelAction += DisablePanel;
        }

        void DisablePanel()
        {
            gameObject.SetActive(false);
        }

        void OnDisable()
        {
            EventManager.CharcPanelEvent.CharcPanelAction -= DisablePanel; 
        }
    }
}