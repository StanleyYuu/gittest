using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FireUi : MonoBehaviour
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
        if (Player.watchedLevel_02_ExamPaper&&!Player.watchedLevel_02_Fire && PaperUi.getFire && Player.fire)
        {
            MainMenu.ploting = true;
            Time.timeScale = 0;
            Text_Plot.GetComponent<Text>().text = " (Space�~��A�p�Y���L����E���L)";
            Text_Plot.SetActive(true);
            TextImage.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                Image_cooldown.SetActive(true);
                CoolDown.fillAmount -= 0.01f;
                if (CoolDown.fillAmount == 0)
                {
                    spacetime = 54;
                    Image_cooldown.SetActive(false);
                }
            }
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            CoolDown.fillAmount += 1.0f;
            Image_cooldown.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Space) && !Player.watchedLevel_02_Fire&&PaperUi.getFire&&Player.fire)
        {
            spacetime++;
        }
        if (Player.watchedLevel_02_ExamPaper == true&& !Player.watchedLevel_02_Fire)
        {
            if (spacetime == 1)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��u�n���o�ӴN��F�� ";
            }
            else if (spacetime == 2)
            {
                Text_Plot.GetComponent<Text>().text = "�ڮ��_������ ";
            }
            else if (spacetime == 3)
            {
                Text_Plot.GetComponent<Text>().text = "???���Y�ȡA�֦�⡨ ";
            }
            else if (spacetime == 4)
            {
                Text_Plot.GetComponent<Text>().text = "???���A���D�ۤv�b�F���ܡ�";
            }
            else if (spacetime == 5)
            {
                Text_Plot.GetComponent<Text>().text = "???���o�ˤ@�I�N�q�]�S���� ";
            }
            else if (spacetime == 6)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��ڤ��b�G�� ";
            }
            else if (spacetime == 7)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��ڴN�O���Q�ݨ�L�� ";
            }
            else if (spacetime == 8)
            {
                Text_Plot.GetComponent<Text>().text = "???�����O�K�K�� ";
            }
            else if (spacetime == 9)
            {
                Text_Plot.GetComponent<Text>().text = "���I�_���K�A�C�C�a��Ҩ��K�K ";
            }
            else if (spacetime == 10)
            {
                Text_Plot.GetComponent<Text>().text = "???���A�S�Q�k�פF�ܡ� ";
            }
            else if (spacetime == 11)
            {
                Text_Plot.GetComponent<Text>().text = "�ڰ��U�ʧ@��ݹD  ";
            }
            else if (spacetime == 12)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ�����?�� ";
            }
            else if (spacetime == 13)
            {
                Text_Plot.GetComponent<Text>().text = "???���A�C���J�����N�u�Q�۰k�ס� ";
            }
            else if (spacetime == 14)
            {
                Text_Plot.GetComponent<Text>().text = "???���o�˭n�k�줰��ɭԡ� ";
            }
            else if (spacetime == 15)
            {
                Text_Plot.GetComponent<Text>().text = "�ڨI�q���y ";
            }
            else if (spacetime == 16)
            {
                Text_Plot.GetComponent<Text>().text = "???���N���o�i�Ҩ��@�ˡ� ";
            }
            else if (spacetime == 17)
            {
                Text_Plot.GetComponent<Text>().text = "???���A�ڥ��N�����D�A���̿��F�� ";
            }
            else if (spacetime == 18)
            {
                Text_Plot.GetComponent<Text>().text = "???���ݳ����ݴN��L���F�� ";
            }
            else if (spacetime == 19)
            {
                Text_Plot.GetComponent<Text>().text = "???���o�˫��|�i�B�O�� ";
            }
            else if (spacetime == 20)
            {
                Text_Plot.GetComponent<Text>().text = "�������b�Ȥl�W�A�ᱼ�F������ ";
            }
            else if (spacetime == 21)
            {
                Text_Plot.GetComponent<Text>().text = "�����y�� ";
            }
            else if (spacetime == 22)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ�������K�K�� ";
            }
            else if (spacetime == 23)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��ک�������V�O�F�� ";
            }
            else if (spacetime == 24)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��o�٬O�o�˪����G�� ";
            }
            else if (spacetime == 25)
            {
                Text_Plot.GetComponent<Text>().text = "???���յۭ���a�� ";
            }
            else if (spacetime == 26)
            {
                Text_Plot.GetComponent<Text>().text = "???�������ۤv�����~�� ";
            }
            else if (spacetime == 27)
            {
                Text_Plot.GetComponent<Text>().text = "???���M��勵�L�� ";
            }
            else if (spacetime == 28)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��i�O...�� ";
            }
            else if (spacetime == 29)
            {
                Text_Plot.GetComponent<Text>().text = "???���p�G�@�ӤH�줣�쪺�ܡ� ";
            }
            else if (spacetime == 30)
            {
                Text_Plot.GetComponent<Text>().text = "???���i�H�h��B�������ڡ� ";
            }
            else if (spacetime == 31)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��ڨS���B�͡� ";
            }
            else if (spacetime == 32)
            {
                Text_Plot.GetComponent<Text>().text = "???���O�ܡK�K�� ";
            }
            else if (spacetime == 33)
            {
                Text_Plot.GetComponent<Text>().text = "???�����ܤ֡K�A�٦��ڡ� ";
            }
            else if (spacetime == 34)
            {
                Text_Plot.GetComponent<Text>().text = "???���ڷ|�@�����ۧA�� ";
            }
            else if (spacetime == 35)
            {
                Text_Plot.GetComponent<Text>().text = "???���ҥH���@�_�ӡK�n��?�� ";
            }
            else if (spacetime == 36)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��n�K�K�� ";
            }
            else if (spacetime == 37)
            {
                Text_Plot.GetComponent<Text>().text = "�������y�W���\�] ";
            }
            else if (spacetime == 38)
            {
                Text_Plot.GetComponent<Text>().text = "�J�ӬݤF�ݤ�W���Ҩ� ";
            }
            else if (spacetime == 39)
            {
                Text_Plot.GetComponent<Text>().text = "�o�{�̭��T��u�O�ڲʤ߼g���Ӥw ";
            }
            else if (spacetime == 40)
            {
                Text_Plot.GetComponent<Text>().text = "???�����ˡ� ";
            }
            else if (spacetime == 41)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ���K�K�� ";
            }
            else if (spacetime == 42)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��ڤ��|�A�k�פF�� ";
            }
            else if (spacetime == 43)
            {
                Text_Plot.GetComponent<Text>().text = "???���ܦn�� ";
            }
            else if (spacetime == 44)
            {
                Text_Plot.GetComponent<Text>().text = "???������K�K�� ";
            }
            else if (spacetime == 45)
            {
                Text_Plot.GetComponent<Text>().text = "???�����U�ӥh��B�ͧa�� ";
            }
            else if (spacetime == 46)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��B��?�� ";
            }
            else if (spacetime == 47)
            {
                Text_Plot.GetComponent<Text>().text = "???���S���� ";
            }
            else if (spacetime == 48)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ��i�O�ڨS���K�K�� ";
            }
            else if (spacetime == 49)
            {
                Text_Plot.GetComponent<Text>().text = "???���A�ܧִN�|��쪺�� ";
            }
            else if (spacetime == 50)
            {
                Text_Plot.GetComponent<Text>().text = "���M�٬O�P��ôb ";
            }
            else if (spacetime == 51)
            {
                Text_Plot.GetComponent<Text>().text = "���O�ڤw�g���A�g�� ";
            }
            else if (spacetime == 52)
            {
                Text_Plot.GetComponent<Text>().text = "�ڥX�}�B���X�Ы� ";
            }
            else if (spacetime == 53)
            {
                Text_Plot.GetComponent<Text>().text = "�Y�ȡ���A���a�� ";
            }
            else if (spacetime == 54)
            {
                Text_Plot.SetActive(false);
                TextImage.SetActive(false);
                Time.timeScale = 1;
                MainMenu.ploting = false;
                PaperUi.FireWatched = true;
                Player.watchedLevel_02_Fire = true;
            }
        }
    }
}
