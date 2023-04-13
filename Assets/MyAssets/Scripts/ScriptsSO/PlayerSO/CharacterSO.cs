using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Scriptable object script for characters
[CreateAssetMenu (fileName = "chSO", menuName = "ScriptableObject/Charcter")]
public class CharacterSO : ScriptableObject
{
    public string CharcName;
    public int CharcIndex;
    public AbilitySO[] Abilities;

}
