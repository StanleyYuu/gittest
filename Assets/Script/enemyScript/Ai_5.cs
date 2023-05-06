using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class Ai_5 : MonoBehaviour

{
    public static bool bang_5 = false;
    float stoptime = 0;
    public AudioSource m_SeeMusic;
    private AudioSource SeeMusic;
    private NavMeshAgent agent;
    public GameObject Target;//追蹤目標
    NavMeshAgent Navigator;//導航器
    public static Animator AnimationConroller;//動畫控制器
    float StopDistance;//停止距離
    float AttackDistance;//攻擊範圍
    public float PatrolRange = 15;//巡邏範圍
    float PatorlStartTime, OriginalSpeed;//巡邏開始時間,原始導航speed
    Vector3 OriginalXY, TargetPatrolXY;//原始位置,目標巡邏位置
    private void Start()
    {
        Navigator = GetComponent<NavMeshAgent>();
        AnimationConroller = GetComponent<Animator>();
        StopDistance = 1f;//GetComponent<CapsuleCollider>().radius + Target.gameObject.GetComponent<CapsuleCollider>().radius;
        //GetComponent<CapsuleCollider>().radius用取得自身膠囊碰撞器半徑 + 目標膠囊碰撞器半徑=StopDistance
        AttackDistance = StopDistance + 0.5f;
        OriginalXY = transform.position;
        PatorlStartTime = Time.time;
        OriginalSpeed = Navigator.speed;
        Navigator.updatePosition = false;
        SeeMusic = GetComponent<AudioSource>();
        m_SeeMusic.volume = 0;
    }
    private void Update()
    {
        Target = GameObject.Find("電筒功能");
        if (GameObject.Find("shower5.0").GetComponent<FieldOfView>().canSeePlayer == true)//can it see player
        {
            Navigator.speed = OriginalSpeed;
            Navigation(Target.transform.position);
            Attack();
            m_SeeMusic.volume = 0.1f;
        }
        else
        {
            AnimationConroller.SetBool("StartAttack", false);
            Navigator.speed = 1;
            Patrol();
            m_SeeMusic.volume = 0;
        }
        if (bang_5)
        {
            OriginalSpeed = 0.1f;
            stoptime = 0;
        }
        else if (!bang_5)
        {
            if (stoptime > 2)
            {
                OriginalSpeed = 5.5f;
            }
            stoptime += Time.deltaTime;
        }
    }

    private void OnAnimatorMove()
    {
        transform.position = Navigator.nextPosition;
    }
    void Patrol()//巡邏
    {
        if (AnimationConroller.GetFloat("speed") == 0 || (Time.time > PatorlStartTime + 5))
        {
            float x = OriginalXY.x + Random.Range(-PatrolRange, PatrolRange);
            float y = OriginalXY.y;
            float z = OriginalXY.z + Random.Range(-PatrolRange, PatrolRange);
            TargetPatrolXY = new Vector3(x, y, z);
            PatorlStartTime = Time.time;
        }
        Navigation(TargetPatrolXY);
    }
    void Navigation(Vector3 NavigationTargetXY)//導航*
    {
        if (Vector3.Distance(NavigationTargetXY, transform.position) > StopDistance)
        {
            Navigator.SetDestination(NavigationTargetXY);
            float speed = Navigator.velocity.magnitude;
            Vector3 TurnAround = Quaternion.Inverse(transform.rotation) * Navigator.velocity;
            float direction = Mathf.Atan2(TurnAround.x, TurnAround.z) / 3.14159f;
            AnimationConroller.SetFloat("speed", speed);
            AnimationConroller.SetFloat("direction", direction);
        }
        else
        {
            Navigator.velocity = Vector3.zero;
            AnimationConroller.SetFloat("speed", 0);
            AnimationConroller.SetFloat("direction", 0);
        }
    }
    void Attack()
    {
        if (Vector3.Distance(Target.transform.position, transform.position) <= AttackDistance && AnimationConroller.GetFloat("speed") == 0 && !bang_5)
        //是否少小於攻擊範圍(距離)&&不是在被bang擊中的狀態下
        {
            AnimationConroller.SetBool("StartAttack", true);
        }
        else
        {
            AnimationConroller.SetBool("StartAttack", false);
        }
    }
}