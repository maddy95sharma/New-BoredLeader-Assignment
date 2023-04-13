using System.Collections;
using System.Collections.Generic;
using BoredLeaders;
using UnityEngine;

// Scriptable object script for card 4 Ai Action 
[CreateAssetMenu(fileName = "Player Card4 Playable Action", menuName ="ScriptableObject/AI/Action/Player Card4 Playable")]

public class PlayerCard4PlayableActionSO : AIActionSO
{
    public override void ExecuteAction(NpcController npc)
    {
        Debug.Log("Player Card 4 is not used and can be used");
    }

}
