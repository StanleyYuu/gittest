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
            Text_PaperText.GetComponent<Text>().text = " �Y�ȡ��o�K�o�O�K";
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
            Text_PaperText.GetComponent<Text>().text = "???����?��";
        }
        else if (Paperspacetime == 2)
        {
            Text_PaperText.GetComponent<Text>().text = "???���o���O�Y�ȧA���Ҩ��ܡ�";
        }
        else if (Paperspacetime == 3)
        {
            Text_PaperText.GetComponent<Text>().text = "???��59���A�٦n�ڡ�";
        }
        else if (Paperspacetime == 4)
        {
            Text_PaperText.GetComponent<Text>().text = "�Y�ȡ�������K�|�b�o�̡K��";
        }
        else if (Paperspacetime == 5)
        {
            Text_PaperText.GetComponent<Text>().text = "�Y�ȡ��ک����⥦����F��";
        }
        else if (Paperspacetime == 6)
        {
            Text_PaperText.GetComponent<Text>().text = "�o�O�ڤW���q�Ҫ��Ҩ�";
        }
        else if (Paperspacetime == 7)
        {
            Text_PaperText.GetComponent<Text>().text = "59�������Ҩ�";
        }
        else if (Paperspacetime == 8)
        {
            Text_PaperText.GetComponent<Text>().text = "���M�o�ä��O�ڦҹL���ꪺ�@��";
        }
        else if (Paperspacetime == 9)
        {
            Text_PaperText.GetComponent<Text>().text = "���O�ڨC�ѳ��d�b�Ǯ�";
        }
        else if (Paperspacetime == 10)
        {
            Text_PaperText.GetComponent<Text>().text = "��W�X�Ӥp�ɪ��ɶ��۲�";
        }
        else if (Paperspacetime == 11)
        {
            Text_PaperText.GetComponent<Text>().text = "�̫᪺���G�o�O�p��";
        }
        else if (Paperspacetime == 12)
        {
            Text_PaperText.GetComponent<Text>().text = "�ڱY��F";
        }
        else if (Paperspacetime == 13)
        {
            Text_PaperText.GetComponent<Text>().text = "��ǮɧڴN��Ҩ�����";
        }
        else if (Paperspacetime == 14)
        {
            Text_PaperText.GetComponent<Text>().text = "��줣���D���̪��U����F";
        }
        else if (Paperspacetime == 15)
        {
            Text_PaperText.GetComponent<Text>().text = "�Ӳ{�b";
        }
        else if (Paperspacetime == 16)
        {
            Text_PaperText.GetComponent<Text>().text = "�L�S�X�{�F";
        }
        else if (Paperspacetime == 17)
        {
            Text_PaperText.GetComponent<Text>().text = "�Y�ȡ��i�c��";
        }
        else if (Paperspacetime == 18)
        {
            Text_PaperText.GetComponent<Text>().text = "�ڦA���Q��Ҩ�����";
        }
        else if (Paperspacetime == 19)
        {
            Text_PaperText.GetComponent<Text>().text = "���O�Ҩ��o����ֵ��@��";
        }
        else if (Paperspacetime == 20)
        {
            Text_PaperText.GetComponent<Text>().text = "���˳�������";
        }
        else if (Paperspacetime == 21)
        {
            Text_PaperText.GetComponent<Text>().text = "???�������A�A�b�F����";
        }
        else if (Paperspacetime == 22)
        {
            Text_PaperText.GetComponent<Text>().text = "�ڮڥ����Q�z�|�����n��";
        }
        else if (Paperspacetime == 23)
        {
            Text_PaperText.GetComponent<Text>().text = "�@�ߥu�Q���o�Ҩ�����";
        }
        else if (Paperspacetime == 24)
        {
            Text_PaperText.GetComponent<Text>().text = "�Y�ȡ��ɡ�";
        }
        else if (Paperspacetime == 25)
        {
            Text_PaperText.GetComponent<Text>().text = "�ڨ��F�X�h";
        }
        else if (Paperspacetime == 26)
        {
            Text_PaperText.GetComponent<Text>().text = "???���Y�ȡA�A�n�h���̡�";
        }
        else if (Paperspacetime == 27)
        {
            Text_PaperText.GetComponent<Text>().text = "�Y�ȡ��@�w�������L����k��";
        }
        else if (Paperspacetime == 28)
        {
            Text_PaperText.GetComponent<Text>().text = "���U�uSpace�v�~��";
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
