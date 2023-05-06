using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public string scenepassword;
    public static Player instance;


    private float TPtimer = 0;
    public float TPCooldown;
    Animator AnimationController;
    public CharacterController controller;
    public static int click = 0;
    public GameObject m_phone;
    public float speed = 2f;//移動速度
    bool timestart=false;//default false
    bool timeend = true;//default true
    int timer_i=100;//電量

    public float m_TimeSecondDividedby100 =6.5f;
    public GameObject m_light;
    public GameObject m_player;
    public GameObject m_enemy;
    public GameObject m_enemy_2;
    public GameObject m_enemy_3;
    public GameObject m_enemy_4;
    public GameObject m_enemy_5;
    public GameObject m_enemy_6;
    public GameObject m_enemy_7;
    public GameObject m_enemy_8;
    public GameObject m_enemy_9;
    public Text m_TimerUi;
    float minDistance = 8f;//距離
    float minAngle = 120f;//角度
    public static bool paper = false;
    public static bool fire = false;
    public static bool fire_ED = false;
    public static bool The_00_Key = false;
    public static bool HitDoor = false;
    public static bool HitDoor1 = false;
    public static bool HitBook = false;
    public static bool hitcup = false;
    public static bool hitEnd1 = false;
    public static bool lastdoor = false;

    public static Vector3 position { get; internal set; }

    string m_MyFirstScene;
    string m_MyFirstScene1;
    string m_MyFirstScene2;
    string m_MyFirstScene3;
    string m_MyFirstScene4;
    public Scene m_Scene;

    public static int HitTime;
    public static GameObject m_blood1;
    public static GameObject m_blood2;
    public static GameObject m_blood3;
    public static GameObject m_blood4;
    public static GameObject m_blood5;

    float Speed;
    public float InPublicWalkSpeed;
    public float InPublicChangeRunSpeed;
    bool CanHoldShift;

    private float ftime;
    bool StartUseEnergy;
    bool HaveEnergy;
    public float EnergyCanUseSecond;
    float BasicEnergyCanUseSecond;
    public Image EnergyImage;
    float ImagefillAmount;

    public GameObject m_paperget;
    public GameObject m_Fireget;
    public GameObject colorbook;
    bool HitBookEDPlayerScript=false;
    public GameObject colorF;
    public static bool colorRedF_ED;
    public static bool colorBlueF_ED;
    public static bool colorYellowF_ED;
    public static bool hit_level01_room;
    public static bool hit_Cabinet;
    public GameObject GetColorP_123;
    public GameObject GetColorPaperObjedt;
    public static int colorpaper=0;
    bool hitRedP;
    bool hitBlueP;
    bool hitYellowP;
    public static bool watchedLevel_02_ExamPaper = false;//1
    public static bool watchedLevel_02_Fire=false;//2
    public static bool watchedLevel_03Plot=false;//3book
    public static bool watchedLevel_03PaperPlot=false;//4
    public static bool watchedRoomPlotUi=false;//5
    public static bool watchedCabinetPlot=false;//6
    public static bool MazeTrap=false;//
    public static bool MazeKey=false;//GetLevel_01Key
    public static bool HitHallDoor=false;//HitHallDoor
    public static bool GetEdColorRed=false;
    public static bool GetEdColorBlue=false;
    public static bool GetEdColorYellow=false;
    private void Start()
    {
        paper = false;
        fire = false;
        fire_ED = false;
        The_00_Key = false;
        HitDoor = false;
        HitDoor1 = false;
        HitBook = false;
        hitcup = false;
        hitEnd1 = false;
        lastdoor = false;
        colorpaper = 0;
        watchedLevel_02_ExamPaper = false;//1
        watchedLevel_02_Fire = false;//2
        watchedLevel_03Plot = false;//3book
        watchedLevel_03PaperPlot = false;//4
        watchedRoomPlotUi = false;//5
        watchedCabinetPlot = false;//6
        MazeTrap = false;//
        MazeKey = false;//GetLevel_01Key
        HitHallDoor = false;//HitHallDoor
        GetEdColorRed = false;
        GetEdColorBlue = false;
        GetEdColorYellow = false;
        m_MyFirstScene = "StartMenu";
        m_MyFirstScene1 = "FIrstTest";
        m_MyFirstScene2 = "Ch.1_Text";
        m_MyFirstScene3 = "DieMenu";
        m_MyFirstScene4 = "Level_00";
        HitTime = 0;
///////只是Energy bar的變數(
        HaveEnergy = true;
        StartUseEnergy = false;
        CanHoldShift = true;
        BasicEnergyCanUseSecond = EnergyCanUseSecond;
        ImagefillAmount = 0.1f / BasicEnergyCanUseSecond;
        //////////)
        m_paperget.SetActive(false);
        m_Fireget.SetActive(false);
        colorbook.SetActive(false);
        colorF.SetActive(false);
        //
        InvokeRepeating("timer", 0f, m_TimeSecondDividedby100);//名為timer的,第一次間隔幾秒呼叫,每幾秒呼叫一次(秒/電量100),想用多少分鐘就除秒鐘以100(ep,3分鐘 180/100=1.8f)
        AnimationController = GetComponent<Animator>();
        Cursor.visible = false;//隱藏mouse
        Cursor.lockState = CursorLockMode.Confined;
        m_phone.SetActive(false);
        GetColorPaperObjedt.SetActive(false);
        hitRedP = false;
        hitBlueP = false;
        hitYellowP = false;
    }
    void Update()
    {
        if (MainMenu.restart||DieMenu.restart)
        {
            watchedLevel_02_ExamPaper = false;//1
            watchedLevel_02_Fire = false;//2
            watchedLevel_03Plot = false;//3book
            watchedLevel_03PaperPlot = false;//4
            watchedRoomPlotUi = false;//5
            watchedCabinetPlot = false;//6
            MazeTrap = false;
            MazeKey = false;
            HitHallDoor = false;//HitHallDoor
            GetEdColorRed = false;
            GetEdColorBlue = false;
            GetEdColorYellow = false;
        }
        //print(TPtimer);
        TPtimer += Time.deltaTime;
        if (TPtimer > TPCooldown)
        {
            TPtimer = 0;
        }
        /*m_Scene.name != m_MyFirstScene && m_Scene.name != m_MyFirstScene1 && m_Scene.name != m_MyFirstScene2 && m_Scene.name != m_MyFirstScene3*///不是在這些Scenes裡才會執行
        EnergyImage = GameObject.Find("energyimg").GetComponent<Image>();
        m_TimerUi = GameObject.Find("Battery").GetComponent<Text>();
        m_enemy = GameObject.Find("shower1.0");
        m_enemy_2 = GameObject.Find("shower2.0");
        m_enemy_3 = GameObject.Find("shower3.0");
        m_enemy_4 = GameObject.Find("shower4.0");
        m_enemy_5 = GameObject.Find("shower5.0");
        m_enemy_6 = GameObject.Find("shower6.0");
        m_enemy_7 = GameObject.Find("shower7.0");
        m_enemy_8 = GameObject.Find("shower8.0");
        m_enemy_9 = GameObject.Find("shower9.0");
        m_blood1 = GameObject.Find("blood1");
        m_blood2 = GameObject.Find("blood2");
        m_blood3 = GameObject.Find("blood3");
        m_blood4 = GameObject.Find("blood4");
        m_blood5 = GameObject.Find("blood5");
        m_TimerUi.text = "電量:" + timer_i + "%";
        if (Input.GetKey(KeyCode.LeftShift) && HaveEnergy && CanHoldShift)
        {
            StartUseEnergy = true;
            Speed = InPublicChangeRunSpeed;
        }
        else
        {
            CanHoldShift = true;
            StartUseEnergy = false;
            Speed = InPublicWalkSpeed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            CanHoldShift = true;
            StartUseEnergy = false;
            Speed = InPublicWalkSpeed;
        }
        if (StartUseEnergy && EnergyCanUseSecond > 0 && CanHoldShift)//因為按shift了所以計時
        {
            ftime += Time.deltaTime;
            if (ftime >= 0.1f)//想間隔的時間
            {
                EnergyCanUseSecond -= 0.1f;//想每間隔時間做的事 每秒扣的數字
                EnergyImage.GetComponent<Image>().fillAmount -= ImagefillAmount;
                ftime = 0f; //計時器復位 
            }
        }
        else if (EnergyCanUseSecond != BasicEnergyCanUseSecond)//沒有在用體力回體力
        {
            ftime += Time.deltaTime;
            if (ftime >= 0.1f)//想間隔的時間
            {
                EnergyCanUseSecond += 0.1f;//想每間隔時間做的事 每秒扣的數字
                EnergyImage.GetComponent<Image>().fillAmount += ImagefillAmount;
                ftime = 0f; //計時器復位
            }
        }
        if (EnergyCanUseSecond <= 0)//看有沒有Energy
        {
            HaveEnergy = false;
            Speed = InPublicWalkSpeed;
            CanHoldShift = false;
        }
        else
            HaveEnergy = true;
        m_Scene = SceneManager.GetActiveScene();
        float x = Input.GetAxis("Horizontal");//input ad鍵
        float z = Input.GetAxis("Vertical");//input垂直 ws鍵


        Vector3 move = transform.right * x + transform.forward * z;
        if (!controller.isGrounded )//重力
        {
            move.y = -9.8f * 30 * Time.deltaTime;
        }
        controller.Move(move * Speed * Time.deltaTime);

        Vector3 playerPos = m_player.transform.position;
        Vector3 enemyPos = m_enemy.transform.position;
        Vector3 enemyPos_2 = m_enemy_2.transform.position;
        Vector3 enemyPos_3 = m_enemy_3.transform.position;
        Vector3 enemyPos_4 = m_enemy_4.transform.position;
        Vector3 enemyPos_5 = m_enemy_5.transform.position;
        Vector3 enemyPos_6 = m_enemy_6.transform.position;
        Vector3 enemyPos_7 = m_enemy_7.transform.position;
        Vector3 enemyPos_8 = m_enemy_8.transform.position;
        Vector3 enemyPos_9 = m_enemy_9.transform.position;


        float distance = Vector3.Distance(playerPos, enemyPos);
        float distance_2 = Vector3.Distance(playerPos, enemyPos_2);
        float distance_3 = Vector3.Distance(playerPos, enemyPos_3);
        float distance_4 = Vector3.Distance(playerPos, enemyPos_4);
        float distance_5 = Vector3.Distance(playerPos, enemyPos_5);
        float distance_6 = Vector3.Distance(playerPos, enemyPos_6);
        float distance_7 = Vector3.Distance(playerPos, enemyPos_7);
        float distance_8 = Vector3.Distance(playerPos, enemyPos_8);
        float distance_9 = Vector3.Distance(playerPos, enemyPos_9);

        Vector3 srcLocalVect = enemyPos - playerPos;//主角相對於目標的向量
        Vector3 srcLocalVect_2 = enemyPos_2 - playerPos;//主角相對於目標的向量
        Vector3 srcLocalVect_3 = enemyPos_3 - playerPos;//主角相對於目標的向量
        Vector3 srcLocalVect_4 = enemyPos_4 - playerPos;//主角相對於目標的向量
        Vector3 srcLocalVect_5 = enemyPos_5 - playerPos;//主角相對於目標的向量
        Vector3 srcLocalVect_6 = enemyPos_6 - playerPos;//主角相對於目標的向量
        Vector3 srcLocalVect_7 = enemyPos_7 - playerPos;//主角相對於目標的向量
        Vector3 srcLocalVect_8 = enemyPos_8 - playerPos;//主角相對於目標的向量
        Vector3 srcLocalVect_9 = enemyPos_9 - playerPos;//主角相對於目標的向量


        srcLocalVect.y = 0;
        srcLocalVect_2.y = 0;
        srcLocalVect_3.y = 0;
        srcLocalVect_4.y = 0;
        srcLocalVect_5.y = 0;
        srcLocalVect_6.y = 0;
        srcLocalVect_7.y = 0;
        srcLocalVect_8.y = 0;
        srcLocalVect_9.y = 0;

        Vector3 forwardLocalPos = m_player.transform.forward * 1 + playerPos;//獲取主角正前方的一個點
        Vector3 forwardLocalVect = forwardLocalPos - playerPos;//獲取正方向向量
        forwardLocalVect.y = 0;

        float angle = Vector3.Angle(srcLocalVect, forwardLocalVect);//計算角度
        float angle_2 = Vector3.Angle(srcLocalVect_2, forwardLocalVect);
        float angle_3 = Vector3.Angle(srcLocalVect_3, forwardLocalVect);
        float angle_4 = Vector3.Angle(srcLocalVect_4, forwardLocalVect);
        float angle_5 = Vector3.Angle(srcLocalVect_5, forwardLocalVect);
        float angle_6 = Vector3.Angle(srcLocalVect_6, forwardLocalVect);
        float angle_7 = Vector3.Angle(srcLocalVect_7, forwardLocalVect);
        float angle_8 = Vector3.Angle(srcLocalVect_8, forwardLocalVect);
        float angle_9 = Vector3.Angle(srcLocalVect_9, forwardLocalVect);
        if (distance < minDistance && angle < minAngle / 2 && click == 1 && timeend == true)//若電池有電,電筒是否在有效射程
        {
            StartCoroutine(WaitLight1f(1f));
        }
        else
        {
            Ai.bang = false;
        }
        if (distance_2 < minDistance && angle_2 < minAngle / 2 && click == 1 && timeend == true)//若電池有電,電筒是否在有效射程
        {
            StartCoroutine(WaitLight1f_2(1f));
        }
        else
        {
            Ai_2.bang_2 = false;
        }
        if (distance_3 < minDistance && angle_3 < minAngle / 2 && click == 1 && timeend == true)//若電池有電,電筒是否在有效射程
        {
            StartCoroutine(WaitLight1f_3(1f));
        }
        else
        {
            Ai_3.bang_3 = false;

        }
        if (distance_4 < minDistance && angle_4 < minAngle / 2 && click == 1 && timeend == true)//若電池有電,電筒是否在有效射程
        {
            StartCoroutine(WaitLight1f_4(1f));
        }
        else
        {
            Ai_4.bang_4 = false;

        }
        if (distance_5 < minDistance && angle_5 < minAngle / 2 && click == 1 && timeend == true)//若電池有電,電筒是否在有效射程
        {
            StartCoroutine(WaitLight1f_5(1f));
        }
        else
        {
            Ai_5.bang_5 = false;

        }
        if (distance_6 < minDistance && angle_6 < minAngle / 2 && click == 1 && timeend == true)//若電池有電,電筒是否在有效射程
        {
            StartCoroutine(WaitLight1f_6(1f));
        }
        else
        {
            Ai_6.bang_6 = false;

        }
        if (distance_7 < minDistance && angle_7 < minAngle / 2 && click == 1 && timeend == true)//若電池有電,電筒是否在有效射程
        {
            StartCoroutine(WaitLight1f_7(1f));
        }
        else
        {
            Ai_7.bang_7 = false;

        }
        if (distance_8 < minDistance && angle_8 < minAngle / 2 && click == 1 && timeend == true)//若電池有電,電筒是否在有效射程
        {
            StartCoroutine(WaitLight1f_8(1f));
        }
        else
        {
            Ai_8.bang_8 = false;

        }
        if (distance_9 < minDistance && angle_9 < minAngle / 2 && click == 1 && timeend == true)//若電池有電,電筒是否在有效射程
        {
            StartCoroutine(WaitLight1f_9(1f));
        }
        else
        {
            Ai_9.bang_9 = false;

        }
        if (Input.GetMouseButtonDown(0))
        {
            if (click == 2)
            {
                Debug.Log("ClickTooFast!!!");
            }
            else if (click == 0)//舉手開燈
            {
                m_phone.SetActive(true);
                AnimationController.SetBool("attacking", true);
                timestart = true;
                click = 1;
            }
            else if (click == 1)//放手關燈
            {
                AnimationController.SetBool("attacking", false);
                StartCoroutine(Wait1f(1f));
                click = 2;
            }

        }
        if (PaperUi.paperget == true)
        {
            m_paperget.SetActive(true);
        }
        else
            m_paperget.SetActive(false);
        if (PaperUi.fireget == true)
        {
            m_Fireget.SetActive(true);
        }
        else
            m_Fireget.SetActive(false);
        if (level_03plot.colorbook==true)
        {
            colorbook.SetActive(true);
            HitBookEDPlayerScript = true;
            GetColorPaperObjedt.SetActive(true);
        }
        //else
            //colorbook.SetActive(false);
            //HitBookEDPlayerScript = false;
            //GetColorPaperObjedt.SetActive(false);
        if (hitRedP)
        {
            if ((Input.GetKeyDown(KeyCode.F)))
            {
                colorF.SetActive(false);
                colorRedF_ED = true;
                colorpaper += 1;
                hitRedP = false;
                GetEdColorRed = true;
                GetColorP_123.GetComponent<Text>().text = colorpaper + "/3";
            }
        }
        if (hitBlueP)
        {
            if ((Input.GetKeyDown(KeyCode.F)))
            {
                colorF.SetActive(false);
                colorBlueF_ED = true;
                colorpaper += 1;
                hitBlueP = false;
                GetEdColorBlue = true;
                GetColorP_123.GetComponent<Text>().text = colorpaper + "/3";
            }
        }
        if (hitYellowP)
        {
            if ((Input.GetKeyDown(KeyCode.F)))
            {
                colorF.SetActive(false);
                colorYellowF_ED = true;
                colorpaper += 1;
                hitYellowP = false;
                GetEdColorYellow = true;
                GetColorP_123.GetComponent<Text>().text = colorpaper + "/3";
            }
        }
    }
    void timer()//電池
    {
        if (timestart == true && timeend == true && m_Scene.name != m_MyFirstScene && m_Scene.name != m_MyFirstScene1 && m_Scene.name != m_MyFirstScene2 && m_Scene.name != m_MyFirstScene3)
        {
            m_TimerUi.text = "電量:" + timer_i + "%";
            timer_i -= 1;//////////////////////////////////////////////////////////////////////////////////////////////
            if (timer_i == 0)
            {
                timeend = false;
                m_light.SetActive(false);
                m_TimerUi.text = "電量:0%";
                CancelInvoke("timer");//CancelInvoke取消重複呼叫(“函式名”)
            }
        }
    }
    IEnumerator Wait1f(float waitTime)//關燈
    {
        yield return new WaitForSeconds(waitTime);
        m_phone.SetActive(false);
        timestart = false;
        click = 0;
    }
    IEnumerator WaitLight1f(float waitTime)//有效
    {
        yield return new WaitForSeconds(waitTime);
        Ai.bang = true;
    }
    IEnumerator WaitLight1f_2(float waitTime)//有效
    {
        yield return new WaitForSeconds(waitTime);
        Ai_2.bang_2 = true;
    }
    IEnumerator WaitLight1f_3(float waitTime)//有效
    {
        yield return new WaitForSeconds(waitTime);
        Ai_3.bang_3 = true;
        print("work");
    }
    IEnumerator WaitLight1f_4(float waitTime)//有效
    {
        yield return new WaitForSeconds(waitTime);
        Ai_4.bang_4 = true;
    }
    IEnumerator WaitLight1f_5(float waitTime)//有效
    {
        yield return new WaitForSeconds(waitTime);
        Ai_5.bang_5 = true;
    }
    IEnumerator WaitLight1f_6(float waitTime)//有效
    {
        yield return new WaitForSeconds(waitTime);
        Ai_6.bang_6 = true;
    }
    IEnumerator WaitLight1f_7(float waitTime)//有效
    {
        yield return new WaitForSeconds(waitTime);
        Ai_7.bang_7 = true;
    }
    IEnumerator WaitLight1f_8(float waitTime)//有效
    {
        yield return new WaitForSeconds(waitTime);
        Ai_8.bang_8 = true;
    }
    IEnumerator WaitLight1f_9(float waitTime)//有效
    {
        yield return new WaitForSeconds(waitTime);
        Ai_9.bang_9 = true;
    }
    public static void DeductBlood()
    {
        HitTime += 1;
        if (HitTime==1)
        {
            m_blood1.SetActive(false);
        }
        else if (HitTime == 2)
        {
            m_blood2.SetActive(false);
        }
        else if (HitTime == 3)
        {
            m_blood3.SetActive(false);
        }
        else if (HitTime == 4)
        {
            m_blood4.SetActive(false);
        }
        else if (HitTime==5)
        {
            m_blood5.SetActive(false);
            SceneManager.LoadScene("DieMenu");
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "00_End")
        {
            hitEnd1 = true;
        }
    }
    void OnTriggerEnter(Collider other)//撞擊
    {
        //if (other.tag == "00_End")
        //{
        //    hitEnd1 = true;
        //}
        //else
        //    hitEnd1 = false;
        if (other.tag == "00_Key")
        {
            The_00_Key = true;
        }
        if (other.tag == "class00Door" && !Level_00Tigger.classKeyED)
        {
            HitDoor1 = true;
        }
        if (other.tag == "class00Door"&&Level_00Tigger.classKeyED)
        {
            HitDoor = true;
        }
        else if (!Level_00Tigger.classKeyED)
        {
            HitDoor = false;
        }
        if (other.tag == "paper")//撞擊考卷
        {
            paper = true;
        }
        else
            paper = false;
        if (other.tag == "fire"&& PaperUi.getpaper==true&&PaperUi.FireF_ed==true)//撞擊打火機
        {
            fire = true;
        }
        else
            fire = false;
        if (other.tag == "book"&& fire_ED == true )
        {
            HitBook = true;
        }
        else
            HitBook = false;
        if (other.tag=="colorRed"&& HitBookEDPlayerScript == true)
        {
            colorF.GetComponent<Text>().text = "按F拿取[紅色紙]";
            colorF.SetActive(true);
            colorRedF_ED = false;
            hitRedP = true;
        }
        if (other.tag == "colorBlue"&& HitBookEDPlayerScript == true )
        {
            colorF.GetComponent<Text>().text = "按F拿取[藍色紙]";
            colorF.SetActive(true);
            colorBlueF_ED = false;
            hitBlueP = true;
        }
        if (other.tag == "colorYellow"&& HitBookEDPlayerScript == true )
        {
            colorF.GetComponent<Text>().text = "按F拿取[黃色紙]";
            colorF.SetActive(true);
            colorYellowF_ED = false;
            hitYellowP = true;
        }
        if (other.tag == "level01_room")
        {
            hit_level01_room = true;
        }
        else
            hit_level01_room = false;
        if (other.tag == "Cabinet")
        {
            hit_Cabinet = true;
        }
        else
            hit_Cabinet = false;
        if (other.tag=="MazeTrap")
        {
            MazeTrap = true;
        }
        if (other.tag == "Kay_01")
        {
            print("kay_01");
            MazeKey = true;
        }
        else
            MazeKey = false;
        if (other.tag == "HallDoor"&&MazeKey)
        {
            HitHallDoor = true;
        }
        if (other.tag == "cup")
        {
            hitcup = true;
        }
        else
            hitcup = false;
        if (other.tag=="LastDoor")
        {
            lastdoor = true;
        }
        else
            lastdoor = false;
    }
    void OnTriggerExit(Collider other)//離開到東西
    {
        {
            fire = false;
            paper = false;
            The_00_Key = false;
            HitDoor = false;
            HitDoor1 = false;
            HitBook = false;
            colorF.SetActive(false);
            hitRedP = false;
            hitBlueP = false;
            hitYellowP = false;
            hit_level01_room = false;
            hit_Cabinet = false;
            hitcup = false;
            MazeKey = false;
        }
    }
}