using System.Collections;
using System.Collections.Generic;
using BoredLeaders;
using UnityEngine;

// Scriptable object script for card 4 Ai consideration 
[CreateAssetMenu(fileName = "Player Card4 Played Consideration", menuName ="ScriptableObject/AI/Consideration/Player Card4 Played Consideration")]
public class PlayerCard4PlayedConsiderationSO : AIConsideratinSO
{
    public override float ConsiderationScore(NpcController npc)
    {
        return npc.PlayerCard4Played ? 0 : 1;

    }
}
