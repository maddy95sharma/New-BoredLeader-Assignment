using System.Collections;
using System.Collections.Generic;
using BoredLeaders;
using UnityEngine;

// Scriptable object script for card 1 Ai Action 

[CreateAssetMenu(fileName = "Player Card1 Playable Action", menuName ="ScriptableObject/AI/Action/Player Card1 Playable")]

public class PlayerCard1PlayableActionSO : AIActionSO
{
    public override void ExecuteAction(NpcController npc)
    {
        Debug.Log("Player Card 1 is not used and can be used");
    }

}
