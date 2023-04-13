// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;


// scriptable object script for ability 2
[CreateAssetMenu(menuName ="ScriptableObject/Ability/Ability2")]
public class Ability2SO : AbilitySO
{

    public override void UseAbility()
    {
        Debug.Log("Using Ability 2");
    }
}
