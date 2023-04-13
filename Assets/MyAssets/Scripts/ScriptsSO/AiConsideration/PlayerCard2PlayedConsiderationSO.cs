using System.Collections;
using System.Collections.Generic;
using BoredLeaders;
using UnityEngine;

// Scriptable object script for card 2 Ai consideration 
[CreateAssetMenu(fileName = "Player Card2 Played Consideration", menuName ="ScriptableObject/AI/Consideration/Player Card2 Played Consideration")]

public class PlayerCard2PlayedConsiderationSO : AIConsideratinSO
{
    public override float ConsiderationScore(NpcController npc)
    {
        return npc.PlayerCard2Played ? 0 : 1;
    }
}
