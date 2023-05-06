using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HistoryRoom : MonoBehaviour
{   
    public bool watched;
    int spacetime;
    public GameObject Table1;
    public GameObject Table2;
    public GameObject Table3;
    public GameObject BackTable1;
    public GameObject BackTable2;
    public GameObject BackTable3;
    public GameObject BackTable4;
    public GameObject BackTable5;
    public GameObject BackTable6;
    public GameObject MazeKey_F_Text;
    public GameObject Text_Plot3;
    public GameObject TextImage3;
    public GameObject Cooldown3;
    public Image Image_cooldown3;
    public GameObject Key_01;
    public static bool F_ed;
    void Start()
    {
        watched = false;
        MazeKey_F_Text = GameObject.Find("MazeKey_F_Text");
        TextImage3 = GameObject.Find("TextImage3");
        Text_Plot3 = GameObject.Find("Plot_Text3");
        Cooldown3 = GameObject.Find("CoolDown3");
        Image_cooldown3 = GameObject.Find("CoolDown3").GetComponent<Image>();
        Text_Plot3.SetActive(false);
        TextImage3.SetActive(false);
        Cooldown3.SetActive(false);
        BackTable1 = GameObject.Find("�ǥͮ�.590");
        BackTable2 = GameObject.Find("�ǥͮ�.591");
        BackTable3 = GameObject.Find("�ǥͮ�.592");
        BackTable4 = GameObject.Find("�ǥͮ�.593");
        BackTable5 = GameObject.Find("�ǥͮ�.594");
        BackTable6 = GameObject.Find("�ǥͮ�.595");

    }
    void Update()
    {
        if (Player.MazeTrap)
        {
            Table1.SetActive(true);
            Table2.SetActive(true);
            Table3.SetActive(true);
        }
        if (Player.watchedCabinetPlot&&!Player.MazeTrap)
        {
            Table1.SetActive(false);
            Table2.SetActive(false);
            Table3.SetActive(false);
        }
        else
        {
            Table1.SetActive(true);
            Table2.SetActive(true);
            Table3.SetActive(true);
        }
        if (Player.MazeKey&&!watched)
        {
            MazeKey_F_Text.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                watched = true;
                Key_01.SetActive(false);
                MazeKey_F_Text.SetActive(false);
                MainMenu.ploting = true;
                Text_Plot3.GetComponent<Text>().text = "(Space�~��A�p�Y���L����E���L)";
                Text_Plot3.SetActive(true);
                TextImage3.SetActive(true);
                F_ed = true;
                Time.timeScale = 0;
            }
        }
        else
            MazeKey_F_Text.SetActive(false);
        if (Input.GetKey(KeyCode.E) && F_ed)
        {
            Cooldown3.SetActive(true);
            Image_cooldown3.fillAmount -= 0.01f;
            if (Image_cooldown3.fillAmount == 0)
            {
                spacetime = 8;
                Cooldown3.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && F_ed)
        {
            spacetime++;
        }
        if (spacetime == 1)
        {
            Text_Plot3.GetComponent<Text>().text = "�Y�ȡ��o�O�j§���_�͡� ";
        }
        else if (spacetime == 2)
        {
            Text_Plot3.GetComponent<Text>().text = "�Y�ȡ����|�b�ܮw�̡� ";
        }
        else if (spacetime == 3)
        {
            Text_Plot3.GetComponent<Text>().text = "???���{�b�]�u��h���̤@���s���F�a�� ";
        }
        else if (spacetime == 4)
        {
            Text_Plot3.GetComponent<Text>().text = "�Y�ȡ��]�O�� ";
        }
        else if (spacetime == 5)
        {
            Text_Plot3.GetComponent<Text>().text = "???���j§��̩γ\�õۤ���ᡨ ";
        }
        else if (spacetime == 6)
        {
            Text_Plot3.GetComponent<Text>().text = "�Y�ȡ���K�� ";
        }
        else if (spacetime == 7)
        {
            Text_Plot3.GetComponent<Text>().text = "���}�ܮw�A�e���j§��a ";
        }
        else if (spacetime == 8)
        {
            MazeKey_F_Text.SetActive(false);
            Text_Plot3.SetActive(false);
            TextImage3.SetActive(false);
            Time.timeScale = 1;
            MainMenu.ploting = false;
            Player.watchedCabinetPlot = true;
            spacetime++;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Image_cooldown3.fillAmount += 1.0f;
            Cooldown3.SetActive(false);
        }
        if (F_ed)
        {
            BackTable1.SetActive(false);
            BackTable2.SetActive(false);
            BackTable3.SetActive(false);
            BackTable4.SetActive(false);
            BackTable5.SetActive(false);
            BackTable6.SetActive(false);
        }
    }
}
