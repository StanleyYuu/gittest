using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CupSript : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;
    public static bool watched;
    bool F_ed;
    bool coolingDown;
    int spacetime;
    public GameObject Image_cooldown4;
    public GameObject Text_Plot4;
    public GameObject TextImage4;
    public GameObject F_Text4;
    public Image CoolDown4;
    public GameObject cup;
    bool FuckIt;
    void Start()
    {
        thePlayer = GameObject.Find("�q���\��");
        Text_Plot4 = GameObject.Find("Plot_Text4");
        TextImage4 = GameObject.Find("TextImage4");
        CoolDown4 = GameObject.Find("CoolDown4").GetComponent<Image>();
        Image_cooldown4 = GameObject.Find("CoolDown4");
        F_Text4 = GameObject.Find("F_Text4");
        Image_cooldown4.SetActive(false);
        Text_Plot4.SetActive(false);
        TextImage4.SetActive(false);
        F_Text4.SetActive(false);
        F_ed = false;
        FuckIt = false;
        watched = false;
    }

    void Update()
    {
        if (Player.hitcup && !watched! && !FuckIt)
        {
            F_Text4.SetActive(true);
        }
        else
            F_Text4.SetActive(false);
        if (Input.GetKeyDown(KeyCode.F) && Player.hitcup && !watched)
        {
            FuckIt = true;
            F_Text4.SetActive(false);
            cup.SetActive(false);
            F_ed = true;
            MainMenu.ploting = true;
            Time.timeScale = 0;
            Text_Plot4.GetComponent<Text>().text = "(Space�~��A�p�Y���L����E���L)";
            Text_Plot4.SetActive(true);
            TextImage4.SetActive(true);
        }
        if (Input.GetKey(KeyCode.E) && F_ed && !watched)
        {
            Image_cooldown4.SetActive(true);
            CoolDown4.fillAmount -= 0.01f;
            if (CoolDown4.fillAmount == 0)
            {
                spacetime = 84;
                Image_cooldown4.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && F_ed && !watched)
        {
            spacetime++;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            CoolDown4.fillAmount += 1.0f;
            Image_cooldown4.SetActive(false);
        }
        if (F_ed && !watched)
        {
            if (spacetime == 1)
            {
                Text_Plot4.GetComponent<Text>().text = "�ڰ{���ߩǪ��l���èӨ�R�x�W ";
            }
            else if (spacetime == 2)
            {
                Text_Plot4.GetComponent<Text>().text = "�M�᮳�_���� ";
            }
            else if (spacetime == 3)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ��o�쩳�O�K�� ";
            }
            else if (spacetime == 4)
            {
                Text_Plot4.GetComponent<Text>().text = "�ڬݦV���ת��D�H ";
            }
            else if (spacetime == 5)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ����K�Y�ȡK�� ";
            }
            else if (spacetime == 6)
            {
                Text_Plot4.GetComponent<Text>().text = "���Y�ȡA2020�C�֦~�R�Ф��ɡA�ĥ|�W ";
            }
            else if (spacetime == 7)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ��o�O�ڪ����׶ܡ� ";
            }
            else if (spacetime == 8)
            {
                Text_Plot4.GetComponent<Text>().text = "???���S���� ";
            }
            else if (spacetime == 9)
            {
                Text_Plot4.GetComponent<Text>().text = "???���A�ٰO�o�ܡ� ";
            }
            else if (spacetime == 10)
            {
                Text_Plot4.GetComponent<Text>().text = "???���ꤤ���~���~�������ѥ[�F�R�Ф��ɡ� ";
            }
            else if (spacetime == 11)
            {
                Text_Plot4.GetComponent<Text>().text = "???���̫᮳��ĥ|�W�� ";
            }
            else if (spacetime == 12)
            {
                Text_Plot4.GetComponent<Text>().text = "???�����O�^�a����K�� ";
            }
            else if (spacetime == 13)
            {
                Text_Plot4.GetComponent<Text>().text = "...";
            }
            else if (spacetime == 14)
            {
                Text_Plot4.GetComponent<Text>().text = "...";
            }
            else if (spacetime == 15)
            {
                Text_Plot4.GetComponent<Text>().text = "...";
            }
            else if (spacetime == 16)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�Ȫ����������L�~���ĥ|�W�Ӥw�� ";
            }
            else if (spacetime == 17)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ�����K�� ";
            }
            else if (spacetime == 18)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�Ȫ��������u����o�ئ��Z���p�O���F�� ";
            }
            else if (spacetime == 19)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�Ȫ��������W��������A���Ӫ��ɶ����� ";
            }
            else if (spacetime == 20)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�Ȫ����������p���I���a�� ";
            }
            else if (spacetime == 21)
            {
                Text_Plot4.GetComponent<Text>().text = "�ڦ^��F�ж� ";
            }
            else if (spacetime == 22)
            {
                Text_Plot4.GetComponent<Text>().text = "����ׯ{��F��W";
            }
            else if (spacetime == 23)
            {
                Text_Plot4.GetComponent<Text>().text = "�ڪ��ܤϹ�ڥh���R";
            }
            else if (spacetime == 24)
            {
                Text_Plot4.GetComponent<Text>().text = "�쥻�Q�ۭn�O�o�W����";
            }
            else if (spacetime == 25)
            {
                Text_Plot4.GetComponent<Text>().text = "�ڪ������w�N�|���[ ";
            }
            else if (spacetime == 26)
            {
                Text_Plot4.GetComponent<Text>().text = "�����G�o�O�p��";
            }
            else if (spacetime == 27)
            {
                Text_Plot4.GetComponent<Text>().text = "�ڦn��ڪ� ";
            }
            else if (spacetime == 28)
            {
                Text_Plot4.GetComponent<Text>().text = "���ڧ��չϧ��ܥL�Q�k����";
            }
            else if (spacetime == 29)
            {
                Text_Plot4.GetComponent<Text>().text = "�Q�Q�ٯu�O�i�d�O";
            }
            else if (spacetime == 30)
            {
                Text_Plot4.GetComponent<Text>().text = "�q������ڴN�S�A���R�F ";
            }
            else if (spacetime == 31)
            {
                Text_Plot4.GetComponent<Text>().text = "��ӮI��Ū��";
            }
            else if (spacetime == 32)
            {
                Text_Plot4.GetComponent<Text>().text = "�չϥΥt�@�ؤ�k�����L�{�P�� ";
            }
            else if (spacetime == 33)
            {
                Text_Plot4.GetComponent<Text>().text = "���O�ڳ��w�g���G�F";
            }
            else if (spacetime == 34)
            {
                Text_Plot4.GetComponent<Text>().text = "���Z�̵M�S���_�� ";
            }
            else if (spacetime == 35)
            {
                Text_Plot4.GetComponent<Text>().text = "���K";
            }
            else if (spacetime == 36)
            {
                Text_Plot4.GetComponent<Text>().text = "�ڴN�O�o�˪��H ";
            }
            else if (spacetime == 37)
            {
                Text_Plot4.GetComponent<Text>().text = "���򳣰����n ";
            }
            else if (spacetime == 38)
            {
                Text_Plot4.GetComponent<Text>().text = "???�����K�� ";
            }
            else if (spacetime == 39)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ���?�� ";

            }
            else if (spacetime == 40)
            {
                Text_Plot4.GetComponent<Text>().text = "???�����O���K�� ";
            }
            else if (spacetime == 41)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ��o�n���O?�� ";
            }
            else if (spacetime == 42)
            {
                Text_Plot4.GetComponent<Text>().text = "???�����O�o�˪��A�Y�ȡ� ";
            }
            else if (spacetime == 43)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ����M�O���ˡ� ";
            }
            else if (spacetime == 44)
            {
                Text_Plot4.GetComponent<Text>().text = "???���A�~�|�����F�� ";
            }
            else if (spacetime == 45)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ��~�|?�� ";
            }
            else if (spacetime == 46)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ��b�L�_�w�ڪ��V�O����A�A��ı�o�ڻ~�|�L�ܡ� ";
            }
            else if (spacetime == 47)
            {
                Text_Plot4.GetComponent<Text>().text = "???����ꪨ���L�H�e�K�� ";
            }
            else if (spacetime == 48)
            {
                Text_Plot4.GetComponent<Text>().text = "???���K�]�O�ӻR�̡� ";
            }
            else if (spacetime == 49)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ�����?�� ";
            }
            else if (spacetime == 50)
            {
                Text_Plot4.GetComponent<Text>().text = "???�������b�A�X�ͫe���L�Y�����ˡ� ";
            }
            else if (spacetime == 51)
            {
                Text_Plot4.GetComponent<Text>().text = "???���o���L����A���@�P�B�ʡ� ";
            }
            else if (spacetime == 52)
            {
                Text_Plot4.GetComponent<Text>().text = "???���L�u�O���Ʊ�A����L�@�˪��D�J�� ";
            }
            else if (spacetime == 53)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ����S��ˡ�";
            }
            else if (spacetime == 54)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ��o���O�L�_�w�ڪ��Ǥf�� ";
            }
            else if (spacetime == 55)
            {
                Text_Plot4.GetComponent<Text>().text = "???���A�C�����ɮɡ� ";
            }
            else if (spacetime == 56)
            {
                Text_Plot4.GetComponent<Text>().text = "???���������|�b�����ݵۧA�� ";
            }
            else if (spacetime == 57)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ��K�K�� ";
            }
            else if (spacetime == 58)
            {
                Text_Plot4.GetComponent<Text>().text = "???�������ߩ��O�����ߧA���� ";
            }
            else if (spacetime == 59)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ����K�� ";
            }
            else if (spacetime == 60)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ�������K�� ";
            }
            else if (spacetime == 61)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ�������n�i�D�ڳo�ǡ� ";
            }
            else if (spacetime == 62)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ��A�쩳�O�֡� ";
            }
            else if (spacetime == 63)
            {
                Text_Plot4.GetComponent<Text>().text = "???����ӤH�өʳ��@�ˡA�G�M�O���k�O�� ";
            }
            else if (spacetime == 64)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ����K���D�K�� ";
            }
            else if (spacetime == 65)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ����K�� ";
            }
            else if (spacetime == 66)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ��O�A�ܡK�� ";
            }
            else if (spacetime == 67)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�Ȫ��������Y�ȡA�ܩ�p�o�򦭴N���}�F�A�� ";
            }
            else if (spacetime == 68)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�Ȫ����������A�W�ۭ���o�ǡ� ";
            }
            else if (spacetime == 69)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�Ȫ����������O�����i�O�ܤ���A���ᡨ ";
            }
            else if (spacetime == 70)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�Ȫ��������ҥH�� ";
            }
            else if (spacetime == 71)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�Ȫ��������ݦb���������W�A�򪨪��M�n�a�� ";
            }
            else if (spacetime == 72)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ��ڡK�� ";
            }
            else if (spacetime == 73)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ��ڤ����D�K�� ";
            }
            else if (spacetime == 74)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�Ȫ����������U�A�F�A�Y�ȡ� ";
            }
            else if (spacetime == 75)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ��ڷ|�K�ոլݡK�� ";
            }
            else if (spacetime == 76)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�Ȫ����������§A�A�Y�ȡ� ";
            }
            else if (spacetime == 78)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�Ȫ��������ɶ��t���h�F�� ";
            }
            else if (spacetime == 79)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�Ȫ��������Y�ȧA�]�ӿ��ӤF�� ";
            }
            else if (spacetime == 80)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ����K�A�n���F��?�� ";
            }
            else if (spacetime == 81)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�Ȫ��������Y�ȡA�n�O�o�� ";
            }
            else if (spacetime == 82)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�Ȫ��������ڷ|�@���u�@�A�̪��� ";
            }
            else if (spacetime == 83)
            {
                Text_Plot4.GetComponent<Text>().text = "�Y�ȡ����K�����K�� ";
            }
            else if (spacetime == 84)
            {
                watched = true;
                Text_Plot4.SetActive(false);
                TextImage4.SetActive(false);
                Time.timeScale = 1;
                MainMenu.ploting = false;
                thePlayer.transform.position = teleportTarget.transform.position;
                spacetime++;
            }
            }
        }
    }

