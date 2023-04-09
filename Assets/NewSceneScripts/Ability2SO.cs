using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="ScriptableObject/Ability/Ability2")]
public class Ability2SO : AbilitySO
{
    public override string abilityName => "Ability2";
    public override void UseAbility()
    {
        Debug.Log("Using Ability 2");
    }
}
