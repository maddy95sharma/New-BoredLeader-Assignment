using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

// This class is part of statergy pattern.
// It is responsible for setting _ability of the card and listening to "CardClickEvent" event and use the _ability
// THE SOURCE FOR SETTING THE ABILITY IS NOT DEFINED YET // 
namespace BoredLeaders.Card
{
    public class CardAbilityView : MonoBehaviour 
    {
        private AbilitySO _ability;
        
        // Setting the _ability of the card
        public void SetAbility(AbilitySO _ability){
            this._ability = _ability;
        }

        void Start()
        {
            Text TextComponent = this.transform.GetChild(0).GetComponent<Text>();
            TextComponent.text = _ability.AbilityName;
        }

        void OnEnable()
        {
            EventManager.CardClickAction += OnCardUse; 
        }

        // When "card click" event is triggered, this method will play vfx
        void OnCardUse()
        {
            _ability.VfxEffect.Play();
        }

        // Unsubscribe OnCardUse() to card click event 
        void OnDisabled(){
            EventManager.CardClickAction += OnCardUse; 
        }
    }
}
