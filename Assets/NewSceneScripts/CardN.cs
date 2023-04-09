    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using SO.Helper;
// using System.Reflection;
// using System.Linq;

public class CardN : MonoBehaviour
{
    // AbilitySO ability;
    // void Start()
    // {
        // var abilities = Assembly.GetAssembly(typeof(AbilitySO)).GetTypes().Where(myType => !myType.IsAbstract && myType.IsSubclassOf(typeof(AbilitySO)));
    // }

    // // void SetAbility(IAbility ability){
    // //     AbilitySO newAbility = SOHelper.InitializeSO(ability);
    // // }
    // public void SetAbility(AbilitySO ability){
    //     var newAbility = ScriptableObject.CreateInstance(ability.name) as IAbility;
    //     OnCardUse(newAbility);
    // }

    public void SetAbility(){
        var newAbility = ScriptableObject.CreateInstance<Ability1SO>();
        OnCardUse(newAbility);
    }
    
    void OnCardUse(AbilitySO newAbility)
    {
        newAbility.UseAbility();
    }
}
