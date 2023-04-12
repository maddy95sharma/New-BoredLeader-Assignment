using System.Collections;
using System.Collections.Generic;
using BoredLeaders;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Card1 Played Consideration", menuName ="ScriptableObject/AI/Consideration/Player Card1 Played Consideration")]

public class PlayerCard1PlayedConsiderationSO : AIConsideratinSO
{
    public override float ConsiderationScore(NpcController npc)
    {
        return npc.PlayerCard1Played ? 0 : 1;

    }
}
