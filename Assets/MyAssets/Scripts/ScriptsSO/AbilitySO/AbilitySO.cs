// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;


public abstract class AbilitySO : ScriptableObject, IAbility
{
    public string AbilityName;
    public VisualEffect VfxEffect;
    public abstract void UseAbility();
    
}
