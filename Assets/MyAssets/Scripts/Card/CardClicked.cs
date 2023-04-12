using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This class is responsible for raising an event when the card is clicked  
// Created by: Madhusudan
namespace BoredLeaders.Card
{

    public class CardClicked : MonoBehaviour
    {
        private Button btn;
        
        // Subscribe OnCardClicked to button click event
        void Start()
        {   
            btn = GetComponent<Button>();
            btn.onClick.AddListener(() => OnCardClicked());
        }

        // This Method Raises an event when card is clicked
        public void OnCardClicked()
        {   
            EventManager.RaisCardEvent();
            gameObject.SetActive(false);
        }

        // Removing all subscriptions form button click event
        void OnDisabl()
        {
            btn.onClick.RemoveAllListeners();
        }

    }
}