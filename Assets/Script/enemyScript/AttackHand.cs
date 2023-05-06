using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHand : MonoBehaviour
{
    public static bool DeductBlood;
    private void Start()
    {
        DeductBlood = false;
    }
    void OnTriggerEnter(Collider other)//¼²À»
    {
        if (other.tag == "Player"&&(Ai.AnimationConroller.GetBool("StartAttack")==true || Ai_2.AnimationConroller.GetBool("StartAttack") == true || Ai_3.AnimationConroller.GetBool("StartAttack") == true || Ai_4.AnimationConroller.GetBool("StartAttack") == true || Ai_5.AnimationConroller.GetBool("StartAttack") == true || Ai_6.AnimationConroller.GetBool("StartAttack") == true || Ai_7.AnimationConroller.GetBool("StartAttack") == true || Ai_8.AnimationConroller.GetBool("StartAttack") == true || Ai_9.AnimationConroller.GetBool("StartAttack") == true))
        {
            Player.DeductBlood();
        }    
    }
}
