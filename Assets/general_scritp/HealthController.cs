using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public float HealthValue = 100;//血量
    public KindofCharacter Antagonist;//敵對角色
    public GameObject InjuredEffect;//受傷特效
    public AudioClip InjuredAudio;//受傷音效
    //private void OnTriggerEnter(Collision other)//撞擊
    //{
    //    SendMessage("CharacterDie");
    //    Vector3 TheGetHitXY = hit.GetContact(0).point - transform.position;
    //    float RelativeGetHitAngle = Mathf.Atan2(TheGetHitXY.x, TheGetHitXY.z) / Mathf.PI * 180;//(RelativeGetHitAngle)相對撞擊角度
    //    DamageControll Damage = hit.collider.gameObject.GetComponent<DamageControll>();
    //    if (hit.collider.tag == "Player")
    //        if (Damage != null)
    //            if (Damage.Character == Antagonist && Damage.Attacking)
    //            {
    //                GetComponent<Animator>().SetFloat("TheGetHitAngle", RelativeGetHitAngle);
    //                GetComponent<Animator>().SetTrigger("GetHit");
    //                StartCoroutine("playIjuredEffect", Instantiate(InjuredEffect, hit.GetContact(0).point, Quaternion.Euler(Vector3.zero), transform));//被打的特效
    //                AudioSource.PlayClipAtPoint(InjuredAudio, transform.position);//音效
    //                HealthValue -= Damage.DamageValue * Damage.DamageSynergy;
    //                if (HealthValue <= 0)

    //    }

    //}
    void CharacterDie()
    {
        GetComponent<Animator>().SetBool("Die", true);
        StartCoroutine("ClearCharacter");
    }
    IEnumerator ClearCharacter()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
    IEnumerator playInjuredEffect(GameObject effect)
    {
        yield return new WaitForSeconds(1);
        Destroy(effect);
    }
}
