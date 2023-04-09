using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPredictor : MonoBehaviour
{
    public bool finishDecidingAction {get; set;}
    public AIActionSO actionToDo{ get; set;}
    
    private NpcController npcController;

    void Awake()
    {
        npcController = GetComponent<NpcController>();
    }


    // public void DecideActionToDo(AIActionSO[] actions)
    // {   
    //     float score =0f;
    //     int actionToDoIndex = 0;

    //     for(int i =0; i < actions.Length; i++)
    //     {
    //         if(ActionScore(actions[i]) > score)
    //         {
    //             actionToDoIndex = i;
    //             score = actions[i].Score;
    //         }
    //     }

    //     actionToDo = actions[actionToDoIndex];

    //     finishDecidingAction = true;

    // }

    public void DecideActionToDo(AIActionSO[] actions)
    {  

        for(int i =0; i < actions.Length; i++)
        {
            if(ActionScore(actions[i]) == 1)
            {
                actions[i].ExecuteAction(npcController); 
            }
        }

    }

    float ActionScore(AIActionSO action)
    {
        float score = 1f;
        for(int i=0; i<action.consideration.Length; i++ )
        {
            float considerationScore = action.consideration[i].ConsiderationScore(npcController);
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



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// public class AIPredictor : MonoBehaviour
// {
//     bool _isCard1PlayedUsable, _isCard2PlayedUsable, _isCard3PlayedUsable;
//     CardType playerCard1Type, playerCard2Type, playerCard3Type, playerCard4Type;

//     private Card card1, card2, card3, card4;
//     private bool _isCard1Played, _isCard2Played, _isCard3Played, _isCard4Played;

//     public bool isPlayerCloseToBase, isPlayerCloseToEnemy, isPlayerCloseToEnemyBase, isEnemyCloseToPlayerBase, isPlayerInEnemyBase, isPlayerInBase;

//     bool IsPlayerCloseToEnemy() => isPlayerCloseToEnemy = true; // If player 6 grid away from enemy
//     bool IsPlayerCloseToEnemyBase() => isPlayerCloseToEnemyBase = true; // If player 6 grid away from enemy base
//     bool IsEnemyCloseToPlayerBase() => isEnemyCloseToPlayerBase = true; // If Ai 6 grid away from player base
//     bool IsPlayerCloseToBase() => isPlayerCloseToBase = true; // If player 6 grid away from enemy base
//     bool IsPlayerInBase() => isPlayerInBase = true; // If player in base grid
//     bool IsPlayerInEnemyBase() => isPlayerInEnemyBase = true; // If player in enemy base grid

//     void Start()
//     {
//         card1 = GameObject.Find("Card1").GetComponent<Card>();
//         card2 = GameObject.Find("Card2").GetComponent<Card>();
//         card3 = GameObject.Find("Card3").GetComponent<Card>();

//         _isCard1Played = PlayerCardManager.Instance.IsCard1Played;
//         _isCard2Played = PlayerCardManager.Instance.IsCard2Played;
//         _isCard3Played = PlayerCardManager.Instance.IsCard3Played;

//         CharacterSO playerCharc = CharacterSelector.Instance.GetCharc();

//         if(playerCharc.name == "Arjun")
//             ArjunMethod();
//         else if(playerCharc.name == "Dhuriyodan")
//             DuryodhanMethod();
//         else if(playerCharc.name == "Shakuni")
//             ShakuniMethod();
//         else if(playerCharc.name == "Balaram")
//             BalramMethod();

//     }

//     void DuryodhanMethod()
//     {
//         if ( !_isCard1Played && isPlayerInBase) //!releaseCard
//         {
//             _isCard1PlayedUsable = true;
//         }
//         else
//         {
//             _isCard1PlayedUsable = false;
//         }

//         if ( !_isCard2Played && isPlayerCloseToEnemy) //!defendPlayerCard
//         {
//             _isCard2PlayedUsable = true;
//         }
//         else
//         {
//             _isCard2PlayedUsable = false;
//         }

//         if ( !_isCard3Played && (isPlayerCloseToEnemy || isPlayerCloseToBase || isPlayerCloseToEnemyBase)) //!rollTwiceCard
//         {
//             _isCard3PlayedUsable = true;
//         }
//         else
//         {
//             _isCard3PlayedUsable = false;
//         }
//     }

//     void ShakuniMethod()
//     {
//         if ( !_isCard1Played && isPlayerInBase) //!releaseCard
//         {
//             _isCard1PlayedUsable = true;
//         }
//         else
//         {
//             _isCard1PlayedUsable = false;
//         }

//         if ( !_isCard2Played && isEnemyCloseToPlayerBase) //!defendBaseCard
//         {
//             _isCard2PlayedUsable = true;
//         }
//         else
//         {
//             _isCard2PlayedUsable = false;
//         }

//         if ( !_isCard3Played && (isPlayerCloseToEnemy || isPlayerCloseToBase || isPlayerCloseToEnemyBase)) //!rollTwiceCard
//         {
//             _isCard3PlayedUsable = true;
//         }
//         else
//         {
//             _isCard3PlayedUsable = false;
//         }
//     }

//     void ArjunMethod()
//     {
//         if ( (!_isCard2Played || !_isCard1Played) && isPlayerInBase) //!releaseCard, reviveCard
//         {
//             _isCard1PlayedUsable = true;
//             _isCard2PlayedUsable = true;
//         }
//         else
//         {
//             _isCard1PlayedUsable = false;
//             _isCard2PlayedUsable = false;
//         }

//         if ( !_isCard3Played && (isPlayerCloseToEnemy || isPlayerCloseToBase || isPlayerCloseToEnemyBase)) //!doubleRollCard
//         {
//             _isCard3PlayedUsable = true;
//         }
//         else
//         {
//             _isCard3PlayedUsable = false;
//         }
//     }

//     void BalramMethod()
//     {
//         if ( (!_isCard2Played || !_isCard1Played) && isPlayerInBase) //!releaseCard, reviveCard
//         {
//             _isCard1PlayedUsable = true;
//             _isCard2PlayedUsable = true;
//         }
//         else
//         {
//             _isCard1PlayedUsable = false;
//             _isCard2PlayedUsable = false;
//         }

//         if ( !_isCard3Played ) //!PushBackCard
//         {
//             _isCard3PlayedUsable = true;
//         }
//         else
//         {
//             _isCard3PlayedUsable = false;
//         }
//     }

// }