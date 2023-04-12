using System;
using System.Collections;
using System.Collections.Generic;
using BoredLeaders.Card;
using UnityEngine;


// This class is responsible for setting up card and its card abilities based on character selection
// Created by: Madhusudan

namespace BordLeaders
{
    public class CardManager : MonoBehaviour
    {
        [SerializeField] private CharacterSO[] _characters;
        private int _charcAbilityCount;
        [SerializeField] private GameObject _cardPrefab;
        [SerializeField] private Transform _cardParent;
        private CharacterSO _playerCharc;

        // When character button is click this method is called
        void OnEnable()
        {
            EventManager.CharcClickEvent.CharcClickAction += SetCards;
        }

        // This class is responsible for setting up card and its card abilities based on character selection
        public void SetCards(int SeclectedCharc) 
        {
            EventManager.CharcPanelEvent.RaisEvent();
            _playerCharc = _characters[SeclectedCharc];
            _charcAbilityCount = _playerCharc.Abilities.Length;
            for (int i =0; i<_charcAbilityCount; i++ )
            {
                GameObject card = Instantiate(_cardPrefab, transform.position, Quaternion.identity, _cardParent);
                CardAbilityView cardAbility = card.GetComponent<CardAbilityView>();
                cardAbility.SetAbility(_playerCharc.Abilities[i]);
            }

        }

        // unsubscribe from events
        void OnDisable()
        {
            EventManager.CharcClickEvent.CharcClickAction -= SetCards; 
        }
    }
}
