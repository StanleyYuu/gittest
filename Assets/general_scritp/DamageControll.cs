using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KindofCharacter { Player, Enemy }
public enum KindofWeapon { hand, foot };
public class DamageControll : MonoBehaviour
{
    public KindofWeapon Weapon;//武器種類
    public KindofCharacter Character;//角色
    public float DamageValue;//傷害值
    public float DamageSynergy = 1;//傷害加乘
    public bool Attacking = false;//是否攻擊中
    public void AttackStart()
    {
        Attacking = true;
    }
    public void AttackEnd()
    {
        Attacking = false;
    }
}
