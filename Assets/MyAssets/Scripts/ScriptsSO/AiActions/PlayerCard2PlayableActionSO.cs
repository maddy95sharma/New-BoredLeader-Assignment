using System.Collections;
using System.Collections.Generic;
using BoredLeaders;
using UnityEngine;

// Scriptable object script for card 2 Ai Action 

[CreateAssetMenu(fileName = "Player Card2 Playable Action", menuName ="ScriptableObject/AI/Action/Player Card2 Playable")]

public class PlayerCard2PlayableActionSO : AIActionSO
{
    public override void ExecuteAction(NpcController npc)
    {
        Debug.Log("Player Card 2 is not used and can be used");
    }

}
