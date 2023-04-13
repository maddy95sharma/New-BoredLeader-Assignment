// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

// scriptable object script for ability 4
[CreateAssetMenu(menuName ="ScriptableObject/Ability/Ability4")]
public class Ability4SO : AbilitySO
{

    public override void UseAbility()
    {
        Debug.Log("Using Ability 4");
    }
}
