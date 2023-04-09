using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour, ICardPlayed
{
    public CardClickSO[] cardClickListener;
    // public CardClickSO card2Click;
    // public CardClickSO card3Click;
    // public CardClickSO card4Click;
    public bool playerCard1Played, playerCard2Played, playerCard3Played, playerCard4Played ;
    public AIPredictor aiPredictor{get;set;}
    public AIActionSO[] ActionSO;

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
    }

    public void onDiceClicked()
    {
        aiPredictor.DecideActionToDo(ActionSO);
    }
 
    void Update()
    {

        // playerCard1Played = PlayerCardManager.Instance.IsCard1Played;
        // playerCard2Played = PlayerCardManager.Instance.IsCard2Played;
        // playerCard3Played = PlayerCardManager.Instance.IsCard3Played;
        // playerCard4Played = PlayerCardManager.Instance.IsCard4Played;

        // if(aiPredictor.finishDecidingAction)
        // {
        //     aiPredictor.finishDecidingAction =false;
        //     aiPredictor.actionToDo.ExecuteAction(this);
        // }
    }

    public void OnCard1Played()
    {
        playerCard1Played = true;
        cardClickListener[0].CardClickEvent -= OnCard1Played;
    }

    public void OnCard2Played()
    {
        playerCard2Played = true;
        cardClickListener[1].CardClickEvent -= OnCard2Played;
    }

    public void OnCard3Played()
    {
        playerCard3Played = true;
        cardClickListener[2].CardClickEvent -= OnCard3Played;
    }

    public void OnCard4Played()
    {
        playerCard4Played = true;
        cardClickListener[3].CardClickEvent -= OnCard4Played;
    }
}
