using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BoredLeaders
{
    public class AIPredictor : MonoBehaviour
    {
        public bool finishDecidingAction {get; set;}
        public AIActionSO actionToDo{ get; set;}
        
        private NpcController _npcController;

        void Awake()
        {
            _npcController = GetComponent<NpcController>();
        }


        public void DecideActionToDo(AIActionSO[] actions)
        {  

            for(int i =0; i < actions.Length; i++)
            {
                if(ActionScore(actions[i]) == 1)
                {
                    actions[i].ExecuteAction(_npcController); 
                }
            }

        }

        float ActionScore(AIActionSO action)
        {
            float score = 1f;
            for(int i=0; i<action.consideration.Length; i++ )
            {
                float considerationScore = action.consideration[i].ConsiderationScore(_npcController);
                score *= considerationScore;

                if(score == 0)
                {
                    action.Score = 0f;
                    return action.Score;
                }
            }

            float originalScore = score;
            float modValue = 1 - (1/action.consideration.Length);
            float makeUpValue = (1 - originalScore) * modValue;
            action.Score = originalScore + (makeUpValue * originalScore);

            return action.Score;
        }
    }
}

