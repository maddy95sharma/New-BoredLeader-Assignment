// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="ScriptableObject/Ability/Ability3")]
public class Ability3SO : AbilitySO
{

    public override void UseAbility()
    {
        Debug.Log("Using Ability 3");
    }
}
