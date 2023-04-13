using System.Collections;
using System.Collections.Generic;
using BoredLeaders;
using UnityEngine;


// Scriptable object script for card 3 Ai Action 
[CreateAssetMenu(fileName = "Player Card3 Playable Action", menuName ="ScriptableObject/AI/Action/Player Card3 Playable")]

public class PlayerCard3PlayableActionSO : AIActionSO
{
    public override void ExecuteAction(NpcController npc)
    {
        Debug.Log("Player Card 3 is not used and can be used");
    }

}
