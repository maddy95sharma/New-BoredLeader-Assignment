using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class listens to "CardClickEvent" and passes the card (used/unused) state to AI action consideration 
// On DiceClickEvent event trigger, Calls DecideActionToDo from AIPredictor
namespace BoredLeaders
{
    public class NpcController : MonoBehaviour, ICardPlayed
    {
        
        public AIPredictor aiPredictor{get;set;}
        [SerializeField] private CardClickEventSO[] cardClickListener;
        [SerializeField] private AIActionSO[] ActionSO;
        private bool playerCard1Played;
        public bool PlayerCard1Played { get { return playerCard1Played;} }
        private bool playerCard2Played;
        public bool PlayerCard2Played{ get { return playerCard2Played;} }
        private bool playerCard3Played;
        public bool PlayerCard3Played{ get { return playerCard3Played;} }
        private bool playerCard4Played;
        public bool PlayerCard4Played{ get { return playerCard4Played;} }

        void Awake()
        {
            aiPredictor = GetComponent<AIPredictor>();
        }

        void Start()
        {
            cardClickListener[0].CardClickEvent += OnCard1Played;
            cardClickListener[1].CardClickEvent += OnCard2Played;
            cardClickListener[2].CardClickEvent += OnCard3Played;
            cardClickListener[3].CardClickEvent += OnCard4Played;
            DiceClicked.DiceClickEvent += onDiceClicked;
        }

        // When "DiceClickEvent" event is triggered this method asks AiPredictor to decide an action
        public void onDiceClicked()
        {
            aiPredictor.DecideActionToDo(ActionSO);
        }

        // sets playerCardPlayed bool to true when CardClickEvent event is triggered Which is refered by AIPredictor to score conditions
        public void OnCard1Played()
        {
            playerCard1Played = true;
        }

        public void OnCard2Played()
        {
            playerCard2Played = true;   
        }

        public void OnCard3Played()
        {
            playerCard3Played = true;  
        }

        public void OnCard4Played()
        {
            playerCard4Played = true;   
        }

        void OnDisabled()
        {
            cardClickListener[0].CardClickEvent -= OnCard1Played;
            cardClickListener[1].CardClickEvent -= OnCard2Played;
            cardClickListener[2].CardClickEvent -= OnCard3Played;
            cardClickListener[3].CardClickEvent -= OnCard4Played;
            DiceClicked.DiceClickEvent -= onDiceClicked;
        }
    }
}
