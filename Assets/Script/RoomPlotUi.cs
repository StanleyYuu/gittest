using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RoomPlotUi : MonoBehaviour
{
    public bool coolingDown;
    int spacetime;
    public GameObject Image_cooldown;
    public GameObject Text_Plot;
    public GameObject TextImage;
    public Image CoolDown;

    void Start()
    {
        Text_Plot = GameObject.Find("Plot_Text2");
        TextImage = GameObject.Find("TextImage2");
        CoolDown = GameObject.Find("CoolDown2").GetComponent<Image>();
        Image_cooldown = GameObject.Find("CoolDown2");
        Image_cooldown.SetActive(false);
        Text_Plot.SetActive(false);
        TextImage.SetActive(false);
    }

    void Update()
    {
        if ( Player.watchedLevel_03PaperPlot&&Player.hit_level01_room==true&&!Player.watchedRoomPlotUi)//
        {
                MainMenu.ploting = true;
                Time.timeScale = 0;
                Text_Plot.GetComponent<Text>().text = "(Space�~��A�p�Y���L����E���L)";
                Text_Plot.SetActive(true);
                TextImage.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                Image_cooldown.SetActive(true);
                CoolDown.fillAmount -= 0.01f;
                if (CoolDown.fillAmount == 0)
                {
                    spacetime = 19;
                    Image_cooldown.SetActive(false);
                }
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                spacetime++;
            }
            if (spacetime == 1)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��o�̬O�K�եv�ǡ� ";
            }
            else if (spacetime == 2)
            {
                Text_Plot.GetComponent<Text>().text = "???���A�̾Ǯկu�h�H�~�� ";
            }
            else if (spacetime == 3)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��O�O�� ";
            }
            else if (spacetime == 4)
            {
                Text_Plot.GetComponent<Text>().text = "����ڬݵ۵Y�w���ت����M�� ";
            }
            else if (spacetime == 5)
            {
                Text_Plot.GetComponent<Text>().text = "???���Y�ȧA�����L���׶ܡ� ";
            }
            else if (spacetime == 6)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��S���� ";
            }
            else if (spacetime == 7)
            {
                Text_Plot.GetComponent<Text>().text = "???���u���S���ܡ� ";
            }
            else if (spacetime == 8)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��u���S���� ";
            }
            else if (spacetime == 9)
            {
                Text_Plot.GetComponent<Text>().text = "???���|���|�S�O�A�ѰO�F�Ӥw�� ";
            }
            else if (spacetime == 10)
            {
                Text_Plot.GetComponent<Text>().text = "???���N���ѰO��ޱ�@�ˡ� ";
            }
            else if (spacetime == 11)
            {
                Text_Plot.GetComponent<Text>().text = "ť�쨺�n���o��@�� ";
            }
            else if (spacetime == 12)
            {
                Text_Plot.GetComponent<Text>().text = "�ڤ��T����F�_�� ";
            }
            else if (spacetime == 13)
            {
                Text_Plot.GetComponent<Text>().text = "�����w�گu�������L���� ";
            }
            else if (spacetime == 14)
            {
                Text_Plot.GetComponent<Text>().text = "���ڨ̵M�S���Y�� ";
            }
            else if (spacetime == 15)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��֪��D�O�� ";
            }
            else if (spacetime == 16)
            {
                Text_Plot.GetComponent<Text>().text = "�ڧN�H�a�^���F�����n�� ";
            }
            else if (spacetime == 17)
            {
                Text_Plot.GetComponent<Text>().text = "���ګo�̵}ı�o";
            }
            else if (spacetime == 18)
            {
                Text_Plot.GetComponent<Text>().text = "���G�u���������׳o�^�� ";
            }
            else if (spacetime == 19)
            {
                Text_Plot.SetActive(false);
                TextImage.SetActive(false);
                Time.timeScale = 1;
                MainMenu.ploting = false;
                Player.watchedRoomPlotUi = true;
            }
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            CoolDown.fillAmount += 1.0f;
            Image_cooldown.SetActive(false);
        }
    }
}
