using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "chSO", menuName = "ScriptableObject/Charcter")]
public class CharacterSO : ScriptableObject
{
    public string CharcName;
    public int CharcIndex;
    public int AbilityCount;
    // public CardSO[] playerCards;
    public AbilitySO[] Abilities;

}
