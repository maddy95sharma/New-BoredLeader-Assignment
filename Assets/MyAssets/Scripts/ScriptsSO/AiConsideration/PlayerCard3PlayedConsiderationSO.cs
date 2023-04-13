using System.Collections;
using System.Collections.Generic;
using BoredLeaders;
using UnityEngine;

// Scriptable object script for card 3 Ai consideration 
[CreateAssetMenu(fileName = "Player Card3 Played Consideration", menuName ="ScriptableObject/AI/Consideration/Player Card3 Played Consideration")]

public class PlayerCard3PlayedConsiderationSO : AIConsideratinSO
{
    public override float ConsiderationScore(NpcController npc)
    {
        return npc.PlayerCard3Played ?  0 : 1;
    }
}
