using System.Collections;
using System.Collections.Generic;
using BoredLeaders;
using UnityEngine;

// Abstract class for Ai Action scriptable object
public abstract class AIActionSO : ScriptableObject
{
    public string Name;
    public AIConsideratinSO[] consideration;

    private float score;
    public float Score{
        get{ return score; }
        set{ score = Mathf.Clamp01(value); }
    }


    public virtual void Awake()
    {
        score = 0;
    }

    public abstract void ExecuteAction(NpcController npc);
}
