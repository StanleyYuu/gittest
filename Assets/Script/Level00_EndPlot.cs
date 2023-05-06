using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level00_EndPlot : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;
    bool F_ed;
    bool coolingDown;
    int spacetime;
    int spacetime2;
    public GameObject Image_cooldown5;
    public GameObject Text_Plot5;
    public GameObject TextImage5;
    public GameObject Image_cooldown6;
    public GameObject Text_Plot6;
    public GameObject TextImage6;
    public GameObject F_Text6;
    public Image CoolDown6;
    public Image CoolDown5;
    void Start()
    {
        thePlayer = GameObject.Find("�q���\��");
        Text_Plot5 = GameObject.Find("Plot_Text5");
        TextImage5 = GameObject.Find("TextImage5");
        CoolDown5 = GameObject.Find("CoolDown5").GetComponent<Image>();
        Image_cooldown5 = GameObject.Find("CoolDown5");
        F_Text6 = GameObject.Find("F_Text6");
        Text_Plot6 = GameObject.Find("Plot_Text6");
        TextImage6 = GameObject.Find("TextImage6");
        CoolDown6 = GameObject.Find("CoolDown6").GetComponent<Image>();
        Image_cooldown6 = GameObject.Find("CoolDown6");
        Image_cooldown6.SetActive(false);
        Text_Plot6.SetActive(false);
        TextImage6.SetActive(false);
        Image_cooldown5.SetActive(false);
        Text_Plot5.SetActive(false);
        TextImage5.SetActive(false);
        F_Text6.SetActive(false);
        F_ed = false;
        spacetime = 0;
        spacetime2 = 0;
    }

    void Update()
    {
        if (Player.hitEnd1&& spacetime==0 )//
        {
            MainMenu.ploting = true;
            Time.timeScale = 0;
            Text_Plot5.GetComponent<Text>().text = "(Space�~��A�p�Y���L����E���L)";
            Text_Plot5.SetActive(true);
            TextImage5.SetActive(true);
        }
        if (Input.GetKey(KeyCode.E)  && spacetime<30 && Player.hitEnd1)//!!!!!!!!!!!!!!!!!!!!
        {
            Image_cooldown5.SetActive(true);
            CoolDown5.fillAmount -= 0.01f;
            if (CoolDown5.fillAmount == 0)
            {
                spacetime = 22;
                Image_cooldown5.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space)&& Player.hitEnd1)//&&F_ed
        {
            spacetime++;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            CoolDown5.fillAmount += 1.0f;
            Image_cooldown5.SetActive(false);
        }

        if (spacetime == 1)
        {
            Text_Plot5.GetComponent<Text>().text = "�Y�ȡ���K�� ";
        }
        else if (spacetime == 2)
        {
            Text_Plot5.GetComponent<Text>().text = "�Y�ȡ��O�ڶܡK�� ";
        }
        else if (spacetime == 3)
        {
            Text_Plot5.GetComponent<Text>().text = "�i��O�ڤӲ֤F ";
        }
        else if (spacetime == 5)
        {
            Text_Plot5.GetComponent<Text>().text = "�ڳ��ѤF�ڤ���ɭԺεۤF ";
        }
        else if (spacetime == 5)
        {
            Text_Plot5.GetComponent<Text>().text = "�����ӹڡK ";
        }
        else if (spacetime == 6)
        {
            Text_Plot5.GetComponent<Text>().text = "�����ӹڡK ";
        }
        else if (spacetime == 7)
        {
            Text_Plot5.GetComponent<Text>().text = "��b�ӹL�u��F ";
        }
        else if (spacetime == 8)
        {
            Text_Plot5.GetComponent<Text>().text = "�Y�ȡ����K�� ";
        }
        else if (spacetime == 9)
        {
            Text_Plot5.GetComponent<Text>().text = "��~�٨Ӥ��θ���D�O ";
        }
        else if (spacetime == 10)
        {
            Text_Plot5.GetComponent<Text>().text = "�ڴN���L�ӤF ";
        }
        else if (spacetime == 11)
        {
            Text_Plot5.GetComponent<Text>().text = "�����N�S���W�X�y�� ";
        }
        else if (spacetime == 12)
        {
            Text_Plot5.GetComponent<Text>().text = "���L�K ";
        }
        else if (spacetime == 13)
        {
            Text_Plot5.GetComponent<Text>().text = "�����q�Y���������b�ڨ���O ";
        }
        else if (spacetime == 15)
        {
            Text_Plot5.GetComponent<Text>().text = "�Y�ȡ����K���§A�� ";
        }
        else if (spacetime == 15)
        {
            Text_Plot5.GetComponent<Text>().text = "�Y�ȡ���F�A�{�b�X�I�F�� ";
        }
        else if (spacetime == 16)
        {
            Text_Plot5.GetComponent<Text>().text = "�Y�ȡ��w�g���I�|�Q���F�� ";
        }
        else if (spacetime == 17)
        {
            Text_Plot5.GetComponent<Text>().text = "�Y�ȡ��o���֦^�a�~�桨 ";
        }
        else if (spacetime == 18)
        {
            Text_Plot5.GetComponent<Text>().text = "�����M�K��  ";
        }
        else if (spacetime == 19)
        {
            Text_Plot5.GetComponent<Text>().text = "�ڬݦV���~ ";
        }
        else if (spacetime == 20)
        {
            Text_Plot5.GetComponent<Text>().text = "�Y�ȡ����M���|��ߪ��� ";
        }
        else if (spacetime == 21)
        {
            Text_Plot5.GetComponent<Text>().text = "�ڦ��B��W�����A�I�W�ѥ]�A���V���f ";
        }
        else if (spacetime == 21)
        {
            Text_Plot5.GetComponent<Text>().text = "����E���L ";
        }
        else if (spacetime == 22)
        {
            spacetime++;
            Text_Plot5.SetActive(false);
            TextImage5.SetActive(false);
            Time.timeScale = 1;
            MainMenu.ploting = false;
        }
        ////////
        if (Player.lastdoor&&!F_ed)
        {
            F_Text6.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                F_Text6.SetActive(false);
                F_ed = true;
                MainMenu.ploting = true;
                Time.timeScale = 0;
                Text_Plot6.GetComponent<Text>().text = "(Space�~��A�p�Y���L����E���L)";
                Text_Plot6.SetActive(true);
                TextImage6.SetActive(true);
            }

        }
        if (Input.GetKey(KeyCode.E)&&F_ed)
        {
            Image_cooldown6.SetActive(true);
            CoolDown6.fillAmount -= 0.01f;
            if (CoolDown6.fillAmount == 0)
            {
                spacetime2 = 3;
                Image_cooldown6.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space)&&F_ed)
        {
            spacetime2++;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            CoolDown6.fillAmount += 1.0f;
            Image_cooldown6.SetActive(false);
        }
        if (spacetime2 == 1)
        {
            Text_Plot6.GetComponent<Text>().text = "�Y�ȡ��H���٬O�� ";
        }
        else if (spacetime2 == 2)
        {
            Text_Plot6.GetComponent<Text>().text = "�Y�ȡ��O�d����ߧa�� ";
        }
        else if (spacetime2 == 3)
        {
            spacetime2++;
            Text_Plot6.SetActive(false);
            TextImage6.SetActive(false);
            Time.timeScale = 1;
            MainMenu.ploting = false;
            SceneManager.LoadScene("TheEnd");
        }
    }
}

