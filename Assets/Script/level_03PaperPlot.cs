using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class level_03PaperPlot : MonoBehaviour
{
    public bool coolingDown;
    int spacetime;
    public GameObject Image_cooldown;
    public GameObject Text_Plot;
    public GameObject TextImage;
    public Image CoolDown;

    void Start()
    {
        Text_Plot = GameObject.Find("Plot_Text");
        TextImage = GameObject.Find("TextImage");
        CoolDown = GameObject.Find("CoolDown").GetComponent<Image>();
        Image_cooldown = GameObject.Find("CoolDown");
        Image_cooldown.SetActive(false);
        Text_Plot.SetActive(false);
        TextImage.SetActive(false);
    }

    void Update()
    {
        if (Player.colorpaper==3&& !Player.watchedLevel_03PaperPlot)
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
                    spacetime = 45;
                    Image_cooldown.SetActive(false);
                }
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                spacetime++;
            }
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            CoolDown.fillAmount += 1.0f;
            Image_cooldown.SetActive(false);
        }
        if (!Player.watchedLevel_03PaperPlot)
        {
            if (spacetime == 1)
            {
                Text_Plot.GetComponent<Text>().text = "???���n�F�A�o�ǯ����Ӱ��F�� ";
            }
            else if (spacetime == 2)
            {
                Text_Plot.GetComponent<Text>().text = "???�����W�ӺP�P�ݧa�� ��";
            }
            else if (spacetime == 3)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ����D�F�� ";
            }
            else if(spacetime == 4)
            {
                Text_Plot.GetComponent<Text>().text = "�Ĥ@���A�O�Ȫ� ";
            }
            else if (spacetime == 5)
            {
                Text_Plot.GetComponent<Text>().text = "���M�����P�A���o���t�ۤ߷N ";
            }
            else if (spacetime == 6)
            {
                Text_Plot.GetComponent<Text>().text = "???���o�O��ޱ�b�A�ͤ�ɰe���A���� ";
            }
            else if (spacetime == 7)
            {
                Text_Plot.GetComponent<Text>().text = "��ޱ���Y�ȡA���A�ͤ�ּ֡� ";
            }
            else if (spacetime == 8)
            {
                Text_Plot.GetComponent<Text>().text = "��ޱ���o�O�e�A���� ";
            }
            else if (spacetime == 9)
            {
                Text_Plot.GetComponent<Text>().text = "��ޱ�C�~���|�e�ڬ����~�֪��Ȫ��  ";
            }
            else if (spacetime == 10)
            {
                Text_Plot.GetComponent<Text>().text = "�ӥB�@�~��@�~��[���R ";
            }
            else if (spacetime == 11)
            {
                Text_Plot.GetComponent<Text>().text = "�����D�o�P�F�h�[? ";
            }
            else if (spacetime == 12)
            {
                Text_Plot.GetComponent<Text>().text = "�ĤG���A�O�t�Ͼ� ";
            }
            else if (spacetime == 13)
            {
                Text_Plot.GetComponent<Text>().text = "��n����ݤW�h������� ";
            }
            else if (spacetime == 14)
            {
                Text_Plot.GetComponent<Text>().text = "���O�K ";
            }
            else if (spacetime == 15)
            {
                Text_Plot.GetComponent<Text>().text = "???���o�O��ޱ�e�A���洫§���� ";
            }
            else if (spacetime == 16)
            {
                Text_Plot.GetComponent<Text>().text = "��ޱ���t�ϧּ֡A�Y�ȡ� ";
            }
            else if (spacetime == 17)
            {
                Text_Plot.GetComponent<Text>().text = "��ޱ���o�ӭn�p�߮��A�����|�������� ";
            }
            else if (spacetime == 18)
            {
                Text_Plot.GetComponent<Text>().text = "���O��ޱ���|�ۤv�e�W�I�� ";
            }
            else if (spacetime == 19)
            {
                Text_Plot.GetComponent<Text>().text = "�٦b�W���[�P�P�������˹� ";
            }
            else if (spacetime == 20)
            {
                Text_Plot.GetComponent<Text>().text = "²�����O���N�~ ";
            }
            else if (spacetime == 21)
            {
                Text_Plot.GetComponent<Text>().text = "���[�ڰe�F����O? ";
            }
            else if (spacetime == 22)
            {
                Text_Plot.GetComponent<Text>().text = "�ĤT���A�O���b ";
            }
            else if (spacetime == 23)
            {
                Text_Plot.GetComponent<Text>().text = "�o��ڨӻ����I�� ";
            }
            else if (spacetime == 24)
            {
                Text_Plot.GetComponent<Text>().text = "�S���ݮѬO�P���X�Ӫ� ";
            }
            else if (spacetime == 25)
            {
                Text_Plot.GetComponent<Text>().text = "???���o�O�ꤤ���~�ɡA��ޱ�e�A���� ";
            }
            else if (spacetime == 26)
            {
                Text_Plot.GetComponent<Text>().text = "???���Y�ȡA�A�n�h���̡�";
            }
            else if (spacetime == 27)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��@�w�������L����k��";
            }
            else if (spacetime == 28)
            {
                Text_Plot.GetComponent<Text>().text = "��ޱ�����~�F�O�Y�ȡ� ";
            }
            else if (spacetime == 29)
            {
                Text_Plot.GetComponent<Text>().text = "��ޱ���ڭ̬O�P�@�Ұ�����a�� ";
            }
            else if (spacetime == 30)
            {
                Text_Plot.GetComponent<Text>().text = "��ޱ�������D�ڭ̷|���|�S�O�P�Z�P�ǡ� ";
            }
            else if (spacetime == 31)
            {
                Text_Plot.GetComponent<Text>().text = "��ޱ�q�ѥ]�̮��X�@����b ";
            }
            else if (spacetime == 32)
            {
                Text_Plot.GetComponent<Text>().text = "�M���i�ڪ���� ";
            }
            else if (spacetime == 33)
            {
                Text_Plot.GetComponent<Text>().text = "��ޱ�����ެO���O�P�Z�A�A���O�ڳ̭n�n���B�ͳᡨ ";
            }
            else if (spacetime == 34)
            {
                Text_Plot.GetComponent<Text>().text = "��ޱ����a�A�Y�ȡ� ";
            }
            else if (spacetime == 35)
            {
                Text_Plot.GetComponent<Text>().text = "�ڳ��Q�_�ӤF ";
            }
            else if (spacetime == 36)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ���ޱ�K�� ";
            }
            else if (spacetime == 37)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ�����ޱ�K�O�ڪ��B�͡� ";
            }
            else if (spacetime == 38)
            {
                Text_Plot.GetComponent<Text>().text = "???���S���� ";
            }
            else if (spacetime == 39)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ�������ڷ|�ѰO�̦n���B�͡� ";
            }
            else if (spacetime == 40)
            {
                Text_Plot.GetComponent<Text>().text = "???���~�򨫧A�N�|���D�F�� ";
            }
            else if (spacetime == 41)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��n�a�� ";
            }
            else if (spacetime == 42)
            {
                Text_Plot.GetComponent<Text>().text = "�ڨ��V���@�Ӫ��ӱ� ";
            }
            else if (spacetime == 43)
            {
                Text_Plot.GetComponent<Text>().text = "��ޱ�K ";
            }
            else if (spacetime == 44)
            {
                Text_Plot.GetComponent<Text>().text = "���ڦ^�h�A�ЧںP�ȧa ";
            }
            else if (spacetime == 45)
            {
                Text_Plot.SetActive(false);
                TextImage.SetActive(false);
                Time.timeScale = 1;
                MainMenu.ploting = false;
                Player.watchedLevel_03PaperPlot = true;
            }
        }
    }
}
