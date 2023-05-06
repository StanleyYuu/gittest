using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class level_03plot : MonoBehaviour
{
    public GameObject book_F_Text;
    public GameObject book;
    public GameObject ColorPaper_Blue;
    public GameObject ColorPaper_Red;
    public GameObject ColorPaper_Yellow;
    public bool coolingDown;
    float waitTime = 3.0f;
    int spacetime;
    public GameObject Image_cooldown;
    public GameObject Text_Plot;
    public GameObject TextImage;
    public Image CoolDown;

    public GameObject color_number_Text;
    public static bool colorbook = false;
    public static bool F_BookED = false;
    bool F_ed;
    void Start()
    {
        CoolDown = GameObject.Find("CoolDown2").GetComponent<Image>();
        Image_cooldown = GameObject.Find("CoolDown2");
        Text_Plot = GameObject.Find("Plot_Text2");
        TextImage = GameObject.Find("TextImage2");
        Image_cooldown.SetActive(false);
        Text_Plot.SetActive(false);

        colorbook = false;
        TextImage.SetActive(false);
        book_F_Text.SetActive(false);
        F_ed = false;
    }
    void Update()
    {
        if (Player.HitBook==true&&F_ed==false&&!Player.watchedLevel_03Plot)
        {
            book_F_Text.SetActive(true);
            if ((Input.GetKeyDown(KeyCode.F)))
            {
                book.SetActive(false);
                colorbook = true;
                book_F_Text.SetActive(false);
                F_ed = true;
                F_BookED = true;
                MainMenu.ploting = true;
                Time.timeScale = 0;
                Text_Plot.GetComponent<Text>().text = "(Space�~��A�p�Y���L����E���L)";
                Text_Plot.SetActive(true);
                TextImage.SetActive(true);
            }
        }
        else
            book_F_Text.SetActive(false);
        if (Input.GetKey(KeyCode.E) && !Player.watchedLevel_03Plot && F_ed == true)
        {
            Image_cooldown.SetActive(true);
            CoolDown.fillAmount -= 0.01f;
            if (CoolDown.fillAmount == 0)
            {
                spacetime = 35;
                Image_cooldown.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && !Player.watchedLevel_03Plot && F_ed == true)
        {
            spacetime++;
        }
        if (Player.watchedLevel_03Plot)
        {
            book_F_Text.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            CoolDown.fillAmount += 1.0f;
            Image_cooldown.SetActive(false);
        }
        if (!Player.watchedLevel_03Plot)
        {
            if (spacetime == 1)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��o�O...�� ";
            }
            else if (spacetime == 2)
            {
                Text_Plot.GetComponent<Text>().text = "�ڬݨ�P�[�l�W��L�Ѥ��P���@���� ";
            }
            else if (spacetime == 3)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��P�ȡK�j���� ";
            }
            else if (spacetime == 4)
            {
                Text_Plot.GetComponent<Text>().text = "???����Ǫ��̫��|��o���ѡ� ";
            }
            else if (spacetime == 5)
            {
                Text_Plot.GetComponent<Text>().text = "��½�}�� ";
            }
            else if (spacetime == 6)
            {
                Text_Plot.GetComponent<Text>().text = "�ݨ�Ĥ@���g�ۤ@�ӦW�r ";
            }
            else if (spacetime == 7)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ����K��ޱ�K�� ";
            }
            else if (spacetime == 8)
            {
                Text_Plot.GetComponent<Text>().text = "�Pı�n���x���W�r�K ";
            }
            else if (spacetime == 9)
            {
                Text_Plot.GetComponent<Text>().text = "???���A���{�Ѷ�?�� ";
            }
            else if (spacetime == 10)
            {
                Text_Plot.GetComponent<Text>().text = "???������ޱ�O�A���B�Ͱڡ� ";
            }
            else if (spacetime == 11)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ���?";
            }
            else if (spacetime == 12)
            {
                Text_Plot.GetComponent<Text>().text = "�B��?�ڦ��o�تF���? ";
            }
            else if (spacetime == 13)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ����i��A�ڤ~�S���K�� ";
            }
            else if (spacetime == 14)
            {
                Text_Plot.GetComponent<Text>().text = "???�������� ";
            }
            else if (spacetime == 15)
            {
                Text_Plot.GetComponent<Text>().text = "???���A�u�O�{�b�Q���_�ӽ}�F�� ";
            }
            else if (spacetime == 16)
            {
                Text_Plot.GetComponent<Text>().text = "???���A�̱q�p�N�{�ѤF ";
            }
            else if (spacetime == 17)
            {
                Text_Plot.GetComponent<Text>().text = "???���N�s�{�b�]�b�P�@�Z�O�� ";
            }
            else if (spacetime == 18)
            {
                Text_Plot.GetComponent<Text>().text = "�ڦA�J�ӬݤF�Ĥ@�� ";
            }
            else if (spacetime == 19)
            {
                Text_Plot.GetComponent<Text>().text = "�G�~���Z�A����ޱ ";
            }
            else if (spacetime == 20)
            {
                Text_Plot.GetComponent<Text>().text = "???����a�� ";
            }
            else if (spacetime == 21)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ����K�� ";
            }
            else if (spacetime == 22)
            {
                Text_Plot.GetComponent<Text>().text = "�O�Цn�ҽk�A���O�ѤF����@�� ";
            }
            else if (spacetime == 23)
            {
                Text_Plot.GetComponent<Text>().text = "???����ޱ�̷R���N�O�P�ȡ� ";
            }
            else if (spacetime == 24)
            {
                Text_Plot.GetComponent<Text>().text = "???���b�t�ϸ`�M�A�ͤ骺�ɭԥL���e�A�P�ȷ�§���� ";
            }
            else if (spacetime == 25)
            {
                Text_Plot.GetComponent<Text>().text = "???���Y�ȡA�A���O�o�F�ܡ� ";
            }
            else if (spacetime == 26)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��ڡK�����D�K�� ";
            }
            else if (spacetime == 27)
            {
                Text_Plot.GetComponent<Text>().text = "�o�ػ����X�Ӫ��Pı�O����? ";
            }
            else if (spacetime == 28)
            {
                Text_Plot.GetComponent<Text>().text = "???���o�˦n�F�� ";
            }
            else if (spacetime == 29)
            {
                Text_Plot.GetComponent<Text>().text = "???�����p�A�]��X�ӺP�ȡ� ";
            }
            else if (spacetime == 30)
            {
                Text_Plot.GetComponent<Text>().text = "???�������w�o�˴N�|�Q�_�ӤF�� ";
            }
            else if (spacetime == 31)
            {
                Text_Plot.GetComponent<Text>().text = "�ڷQ�F�Q ";
            }
            else if (spacetime == 32)
            {
                Text_Plot.GetComponent<Text>().text = "���K�N�o���a�� ";
            }
            else if (spacetime == 33)
            {
                Text_Plot.GetComponent<Text>().text = "�K ";
            }
            else if (spacetime == 34)
            {
                Text_Plot.GetComponent<Text>().text = "��Kޱ�K";
            }
            else if (spacetime == 35)
            {
                Text_Plot.SetActive(false);
                TextImage.SetActive(false);
                Time.timeScale = 1;
                MainMenu.ploting = false;
                Player.watchedLevel_03Plot = true;
            }
        }
        if (Player.watchedLevel_03Plot)
        {
            book.SetActive(false);
        }
        if (Player.colorRedF_ED)//&&Player.GetEdColorRed
        {
            ColorPaper_Red.SetActive(false);
        }
        if (Player.colorBlueF_ED)//&&Player.GetEdColorBlue
        {
            ColorPaper_Blue.SetActive(false);
        }
        if (Player.colorYellowF_ED)//&&Player.GetEdColorYellow
        {
            ColorPaper_Yellow.SetActive(false);
        }
    }
}
