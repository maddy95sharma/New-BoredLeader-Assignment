using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbilitySO : ScriptableObject, IAbility
{
    public abstract string abilityName{ get; }
    public abstract void UseAbility();
    
}
