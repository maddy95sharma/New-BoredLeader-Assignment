using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Card : MonoBehaviour
{
    // public CardSO card;

    public CardClickSO cardClickSO; 
    // private CardType type;
    public Text nameText;
    private string cardName;


    public void Initialize(CardSO card)
    {
        // type = card.type;
        cardName = card.name;
        nameText.text = cardName; 
    } 

    public void OnClicked()
    {   
        DisplayCardAbility();
        cardClickSO.RaisEvent();
        gameObject.SetActive(false);
    }

    void DisplayCardAbility()
    {
        Debug.Log("Card Ability: "+ cardName);
    }

}
