// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;


// scriptable object script for ability 3
[CreateAssetMenu(menuName ="ScriptableObject/Ability/Ability3")]
public class Ability3SO : AbilitySO
{

    public override void UseAbility()
    {
        Debug.Log("Using Ability 3");
    }
}
