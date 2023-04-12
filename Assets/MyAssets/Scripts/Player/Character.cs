using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Detect character button click and triggering the event. 
// Created by: Madhusudan
namespace BordLeaders
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private CharacterSO characterSO;
        private Button _btn;

        // Get ref to button and listen to the button click
        // Set up button text
        void Start()
        {   
            _btn = GetComponentInChildren<Button>();
            _btn.onClick.AddListener(() => OnCharcSelet());

            Text TextComponent = this.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>();
            TextComponent.text = characterSO.CharcName;
        }
        
        // rais charc select event
        public void OnCharcSelet()
        {   
            EventManager.RaisCharcEvent(characterSO.CharcIndex);
            gameObject.transform.parent.gameObject.SetActive(false);
        }

        void OnDisable(){
            _btn.onClick.RemoveAllListeners();
        }
    }
}

