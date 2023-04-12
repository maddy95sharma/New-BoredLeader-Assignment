using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

// This class is part of statergy pattern.
// It is responsible for setting ability of the card and listening to "CardClickEvent" event and use the ability
// THE SOURCE FOR SETTING THE ABILITY IS NOT DEFINED YET // 
namespace BoredLeaders.Card
{
    public class CardAbilityView : MonoBehaviour 
    {
        private AbilitySO ability;
        private Button _btn;
        
        // Setting the ability of the card
        public void SetAbility(AbilitySO ability){
            this.ability = ability;
        }

        void Start()
        {
            Text TextComponent = this.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>();
            TextComponent.text = ability.AbilityName;
        }

        void OnEnable()
        {
            EventManager.CardClickEvent.CardClickAction += OnCardUse; 
        }

        // When "card click" event is triggered, this method will play vfx
        void OnCardUse()
        {
            ability.VfxEffect.Play();
        }

        // Unsubscribe OnCardUse() to card click event 
        void OnDisabled(){
            EventManager.CardClickEvent.CardClickAction += OnCardUse; 
        }
    }
}
