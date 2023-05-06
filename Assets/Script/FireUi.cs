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
            Text_Plot.GetComponent<Text>().text = " (Space繼續，如若跳過按住E跳過)";
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
                Text_Plot.GetComponent<Text>().text = "欣亞“只要有這個就行了” ";
            }
            else if (spacetime == 2)
            {
                Text_Plot.GetComponent<Text>().text = "我拿起打火機 ";
            }
            else if (spacetime == 3)
            {
                Text_Plot.GetComponent<Text>().text = "???“欣亞，快住手” ";
            }
            else if (spacetime == 4)
            {
                Text_Plot.GetComponent<Text>().text = "???“你知道自己在幹嘛嗎”";
            }
            else if (spacetime == 5)
            {
                Text_Plot.GetComponent<Text>().text = "???“這樣一點意義也沒有” ";
            }
            else if (spacetime == 6)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“我不在乎” ";
            }
            else if (spacetime == 7)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“我就是不想看到他” ";
            }
            else if (spacetime == 8)
            {
                Text_Plot.GetComponent<Text>().text = "???“但是……” ";
            }
            else if (spacetime == 9)
            {
                Text_Plot.GetComponent<Text>().text = "我點起火焰，慢慢靠近考卷…… ";
            }
            else if (spacetime == 10)
            {
                Text_Plot.GetComponent<Text>().text = "???“你又想逃避了嗎” ";
            }
            else if (spacetime == 11)
            {
                Text_Plot.GetComponent<Text>().text = "我停下動作後問道  ";
            }
            else if (spacetime == 12)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“什麼?” ";
            }
            else if (spacetime == 13)
            {
                Text_Plot.GetComponent<Text>().text = "???“你每次遇到挫折就只想著逃避” ";
            }
            else if (spacetime == 14)
            {
                Text_Plot.GetComponent<Text>().text = "???“這樣要逃到什麼時候” ";
            }
            else if (spacetime == 15)
            {
                Text_Plot.GetComponent<Text>().text = "我沉默不語 ";
            }
            else if (spacetime == 16)
            {
                Text_Plot.GetComponent<Text>().text = "???“就像這張考卷一樣” ";
            }
            else if (spacetime == 17)
            {
                Text_Plot.GetComponent<Text>().text = "???“你根本就不知道你哪裡錯了” ";
            }
            else if (spacetime == 18)
            {
                Text_Plot.GetComponent<Text>().text = "???“看都不看就把他撕了” ";
            }
            else if (spacetime == 19)
            {
                Text_Plot.GetComponent<Text>().text = "???“這樣怎麼會進步呢” ";
            }
            else if (spacetime == 20)
            {
                Text_Plot.GetComponent<Text>().text = "我癱坐在椅子上，丟掉了打火機 ";
            }
            else if (spacetime == 21)
            {
                Text_Plot.GetComponent<Text>().text = "哭著臉說 ";
            }
            else if (spacetime == 22)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“為什麼……” ";
            }
            else if (spacetime == 23)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“我明明那麼努力了” ";
            }
            else if (spacetime == 24)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“卻還是這樣的結果” ";
            }
            else if (spacetime == 25)
            {
                Text_Plot.GetComponent<Text>().text = "???“試著面對吧” ";
            }
            else if (spacetime == 26)
            {
                Text_Plot.GetComponent<Text>().text = "???“正視自己的錯誤” ";
            }
            else if (spacetime == 27)
            {
                Text_Plot.GetComponent<Text>().text = "???“然後改正他” ";
            }
            else if (spacetime == 28)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“可是...” ";
            }
            else if (spacetime == 29)
            {
                Text_Plot.GetComponent<Text>().text = "???“如果一個人辦不到的話” ";
            }
            else if (spacetime == 30)
            {
                Text_Plot.GetComponent<Text>().text = "???“可以去找朋友幫忙啊” ";
            }
            else if (spacetime == 31)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“我沒有朋友” ";
            }
            else if (spacetime == 32)
            {
                Text_Plot.GetComponent<Text>().text = "???“是嗎……” ";
            }
            else if (spacetime == 33)
            {
                Text_Plot.GetComponent<Text>().text = "???“但至少…你還有我” ";
            }
            else if (spacetime == 34)
            {
                Text_Plot.GetComponent<Text>().text = "???“我會一直陪著你” ";
            }
            else if (spacetime == 35)
            {
                Text_Plot.GetComponent<Text>().text = "???“所以振作起來…好嗎?” ";
            }
            else if (spacetime == 36)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“好……” ";
            }
            else if (spacetime == 37)
            {
                Text_Plot.GetComponent<Text>().text = "我擦乾臉上的淚珠 ";
            }
            else if (spacetime == 38)
            {
                Text_Plot.GetComponent<Text>().text = "仔細看了看手上的考卷 ";
            }
            else if (spacetime == 39)
            {
                Text_Plot.GetComponent<Text>().text = "發現裡面確實只是我粗心寫錯而已 ";
            }
            else if (spacetime == 40)
            {
                Text_Plot.GetComponent<Text>().text = "???“怎麼樣” ";
            }
            else if (spacetime == 41)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“嗯……” ";
            }
            else if (spacetime == 42)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“我不會再逃避了” ";
            }
            else if (spacetime == 43)
            {
                Text_Plot.GetComponent<Text>().text = "???“很好” ";
            }
            else if (spacetime == 44)
            {
                Text_Plot.GetComponent<Text>().text = "???“那麼……” ";
            }
            else if (spacetime == 45)
            {
                Text_Plot.GetComponent<Text>().text = "???“接下來去找朋友吧” ";
            }
            else if (spacetime == 46)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“朋友?” ";
            }
            else if (spacetime == 47)
            {
                Text_Plot.GetComponent<Text>().text = "???“沒錯” ";
            }
            else if (spacetime == 48)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“可是我沒有……” ";
            }
            else if (spacetime == 49)
            {
                Text_Plot.GetComponent<Text>().text = "???“你很快就會找到的” ";
            }
            else if (spacetime == 50)
            {
                Text_Plot.GetComponent<Text>().text = "雖然還是感到疑惑 ";
            }
            else if (spacetime == 51)
            {
                Text_Plot.GetComponent<Text>().text = "但是我已經不再迷惘 ";
            }
            else if (spacetime == 52)
            {
                Text_Plot.GetComponent<Text>().text = "邁出腳步走出教室 ";
            }
            else if (spacetime == 53)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“嗯，走吧” ";
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
