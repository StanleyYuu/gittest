using UnityEngine;
using UnityEngine.UI;

public class PaperUi : MonoBehaviour
{
    public Image PaperTextImage;
    public Text PaperPlot;
    public Image CoolDown;

    public bool coolingDown;
    public float waitTime = 3.0f;
    public GameObject Image_cooldown;
    public GameObject Text_PaperText;
    public GameObject TextImage;

    public GameObject m_paperF;
    public GameObject m_Paper;
    public GameObject m_FireF;
    public GameObject m_Fire;
    public static bool FireF_ed = true;
    public static bool F_ed = true;
    public static bool getpaper;
    public static bool getFire = false;
    public static bool  fireget= false;
    public static bool paperget = false;

    bool PaperWatched;
    public static bool FireWatched;

    int Paperspacetime;
    int Firespacetime;
    void Start()
    {
        PaperPlot = GameObject.Find("PaperPlot").GetComponent<Text>();
        PaperTextImage = GameObject.Find("PaperTextImage").GetComponent<Image>();
        CoolDown = GameObject.Find("CoolDown").GetComponent<Image>();
        Image_cooldown = GameObject.Find("CoolDown");
        Text_PaperText = GameObject.Find("PaperPlot");
        TextImage = GameObject.Find("PaperTextImage");
        Image_cooldown.SetActive(false);
        Text_PaperText.SetActive(false);
        TextImage.SetActive(false);
        m_paperF.SetActive(false);
        m_FireF.SetActive(false);

        Paperspacetime = 0;
        Firespacetime = 0;
        PaperWatched = false;
        FireWatched = false;
        getpaper = false;
        paperget = false;
        fireget = false;
        F_ed = true;
        FireF_ed = true;
        m_Fire.SetActive(true);
    }
    void Update()
    {
        if (Player.paper == false)
        {
            m_paperF.SetActive(false);
        }

        if (Player.paper == true && F_ed == true)
        {
            m_paperF.SetActive(true);
        }
        if ((Input.GetKeyDown(KeyCode.F) && Player.paper)||Player.watchedLevel_02_ExamPaper)
        {
            getpaper = true;
            m_paperF.SetActive(false);
            F_ed = false;
            paperget = true;
            m_Paper.SetActive(false);
            m_paperF.SetActive(false);
            if (Player.paper == true)
            {
                m_Paper.SetActive(false);
            }
        }

        if (getpaper == true && PaperWatched == false&&Player.watchedLevel_02_ExamPaper==false)
        {   
            MainMenu.ploting = true;
            Time.timeScale = 0;
            Text_PaperText.GetComponent<Text>().text = " 欣亞“這…這是…";
            Text_PaperText.SetActive(true);
            TextImage.SetActive(true);
        }
        if (Input.GetKey(KeyCode.E) && getpaper == true && Player.watchedLevel_02_ExamPaper == false)
        {
            Image_cooldown.SetActive(true);
            CoolDown.fillAmount -= 0.01f;
            if (CoolDown.fillAmount == 0)
            {
                Paperspacetime = 29;
                Image_cooldown.SetActive(false);
            }
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            CoolDown.fillAmount += 1.0f;
            Image_cooldown.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Space) && getpaper == true && Player.watchedLevel_02_ExamPaper == false)
        {
            Paperspacetime++;
        }
        else if (Paperspacetime == 1)
        {
            Text_PaperText.GetComponent<Text>().text = "???“嗯?”";
        }
        else if (Paperspacetime == 2)
        {
            Text_PaperText.GetComponent<Text>().text = "???“這不是欣亞你的考卷嗎”";
        }
        else if (Paperspacetime == 3)
        {
            Text_PaperText.GetComponent<Text>().text = "???“59分，還好啊”";
        }
        else if (Paperspacetime == 4)
        {
            Text_PaperText.GetComponent<Text>().text = "欣亞“為什麼…會在這裡…”";
        }
        else if (Paperspacetime == 5)
        {
            Text_PaperText.GetComponent<Text>().text = "欣亞“我明明把它撕爛了”";
        }
        else if (Paperspacetime == 6)
        {
            Text_PaperText.GetComponent<Text>().text = "這是我上次段考的考卷";
        }
        else if (Paperspacetime == 7)
        {
            Text_PaperText.GetComponent<Text>().text = "59分的國文考卷";
        }
        else if (Paperspacetime == 8)
        {
            Text_PaperText.GetComponent<Text>().text = "雖然這並不是我考過最爛的一次";
        }
        else if (Paperspacetime == 9)
        {
            Text_PaperText.GetComponent<Text>().text = "但是我每天都留在學校";
        }
        else if (Paperspacetime == 10)
        {
            Text_PaperText.GetComponent<Text>().text = "花上幾個小時的時間自習";
        }
        else if (Paperspacetime == 11)
        {
            Text_PaperText.GetComponent<Text>().text = "最後的結果卻是如此";
        }
        else if (Paperspacetime == 12)
        {
            Text_PaperText.GetComponent<Text>().text = "我崩潰了";
        }
        else if (Paperspacetime == 13)
        {
            Text_PaperText.GetComponent<Text>().text = "放學時我就把考卷撕爛";
        }
        else if (Paperspacetime == 14)
        {
            Text_PaperText.GetComponent<Text>().text = "丟到不知道哪裡的垃圾桶了";
        }
        else if (Paperspacetime == 15)
        {
            Text_PaperText.GetComponent<Text>().text = "而現在";
        }
        else if (Paperspacetime == 16)
        {
            Text_PaperText.GetComponent<Text>().text = "他又出現了";
        }
        else if (Paperspacetime == 17)
        {
            Text_PaperText.GetComponent<Text>().text = "欣亞“可惡”";
        }
        else if (Paperspacetime == 18)
        {
            Text_PaperText.GetComponent<Text>().text = "我再次想把考卷撕掉";
        }
        else if (Paperspacetime == 19)
        {
            Text_PaperText.GetComponent<Text>().text = "但是考卷卻像橡皮筋一樣";
        }
        else if (Paperspacetime == 20)
        {
            Text_PaperText.GetComponent<Text>().text = "怎麼樣都撕不爛";
        }
        else if (Paperspacetime == 21)
        {
            Text_PaperText.GetComponent<Text>().text = "???“等等，你在幹嘛”";
        }
        else if (Paperspacetime == 22)
        {
            Text_PaperText.GetComponent<Text>().text = "我根本不想理會那個聲音";
        }
        else if (Paperspacetime == 23)
        {
            Text_PaperText.GetComponent<Text>().text = "一心只想讓這考卷消失";
        }
        else if (Paperspacetime == 24)
        {
            Text_PaperText.GetComponent<Text>().text = "欣亞“嘖”";
        }
        else if (Paperspacetime == 25)
        {
            Text_PaperText.GetComponent<Text>().text = "我走了出去";
        }
        else if (Paperspacetime == 26)
        {
            Text_PaperText.GetComponent<Text>().text = "???“欣亞，你要去哪裡”";
        }
        else if (Paperspacetime == 27)
        {
            Text_PaperText.GetComponent<Text>().text = "欣亞“一定有毀掉他的方法”";
        }
        else if (Paperspacetime == 28)
        {
            Text_PaperText.GetComponent<Text>().text = "按下「Space」繼續";
        }
        else if (Paperspacetime == 29)
        {
            Player.watchedLevel_02_ExamPaper = true;
            Text_PaperText.SetActive(false);
            TextImage.SetActive(false);
            MainMenu.ploting = false;
            Time.timeScale = 1;
            Paperspacetime = 30;
            PaperWatched = true;
        }            
        if (Paperspacetime==30)
        {
            print("is work");
            if (Player.fire == false)
            {
                m_FireF.SetActive(false);
            }
            if (Player.fire == true && FireF_ed == true)
            {
                m_FireF.SetActive(true);
            }
            if (((Input.GetKeyDown(KeyCode.F)) && Player.fire == true)||Player.watchedLevel_02_Fire)
            {
                Player.fire_ED = true;
                m_FireF.SetActive(false);
                FireF_ed = false;
                m_Fire.SetActive(false);
                fireget = true;
                getFire = true;
            }
        }
    }
}
