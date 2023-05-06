using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public float HealthValue = 100;//��q
    public KindofCharacter Antagonist;//�Ĺ﨤��
    public GameObject InjuredEffect;//���˯S��
    public AudioClip InjuredAudio;//���˭���
    //private void OnTriggerEnter(Collision other)//����
    //{
    //    SendMessage("CharacterDie");
    //    Vector3 TheGetHitXY = hit.GetContact(0).point - transform.position;
    //    float RelativeGetHitAngle = Mathf.Atan2(TheGetHitXY.x, TheGetHitXY.z) / Mathf.PI * 180;//(RelativeGetHitAngle)�۹Ｒ������
    //    DamageControll Damage = hit.collider.gameObject.GetComponent<DamageControll>();
    //    if (hit.collider.tag == "Player")
    //        if (Damage != null)
    //            if (Damage.Character == Antagonist && Damage.Attacking)
    //            {
    //                GetComponent<Animator>().SetFloat("TheGetHitAngle", RelativeGetHitAngle);
    //                GetComponent<Animator>().SetTrigger("GetHit");
    //                StartCoroutine("playIjuredEffect", Instantiate(InjuredEffect, hit.GetContact(0).point, Quaternion.Euler(Vector3.zero), transform));//�Q�����S��
    //                AudioSource.PlayClipAtPoint(InjuredAudio, transform.position);//����
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
