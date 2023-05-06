using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KindofCharacter { Player, Enemy }
public enum KindofWeapon { hand, foot };
public class DamageControll : MonoBehaviour
{
    public KindofWeapon Weapon;//�Z������
    public KindofCharacter Character;//����
    public float DamageValue;//�ˮ`��
    public float DamageSynergy = 1;//�ˮ`�[��
    public bool Attacking = false;//�O�_������
    public void AttackStart()
    {
        Attacking = true;
    }
    public void AttackEnd()
    {
        Attacking = false;
    }
}
