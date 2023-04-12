// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="ScriptableObject/Ability/Ability1")]
public class Ability1SO : AbilitySO
{

    public override void UseAbility()
    {
        Debug.Log("Using Ability 1");
    }
}
