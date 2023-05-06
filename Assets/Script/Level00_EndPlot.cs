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
        thePlayer = GameObject.Find("電筒功能");
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
            Text_Plot5.GetComponent<Text>().text = "(Space繼續，如若跳過按住E跳過)";
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
            Text_Plot5.GetComponent<Text>().text = "欣亞“嗯…” ";
        }
        else if (spacetime == 2)
        {
            Text_Plot5.GetComponent<Text>().text = "欣亞“是夢嗎…” ";
        }
        else if (spacetime == 3)
        {
            Text_Plot5.GetComponent<Text>().text = "可能是我太累了 ";
        }
        else if (spacetime == 5)
        {
            Text_Plot5.GetComponent<Text>().text = "我都忘了我什麼時候睡著了 ";
        }
        else if (spacetime == 5)
        {
            Text_Plot5.GetComponent<Text>().text = "但那個夢… ";
        }
        else if (spacetime == 6)
        {
            Text_Plot5.GetComponent<Text>().text = "但那個夢… ";
        }
        else if (spacetime == 7)
        {
            Text_Plot5.GetComponent<Text>().text = "實在太過真實了 ";
        }
        else if (spacetime == 8)
        {
            Text_Plot5.GetComponent<Text>().text = "欣亞“媽…” ";
        }
        else if (spacetime == 9)
        {
            Text_Plot5.GetComponent<Text>().text = "剛才還來不及跟媽道別 ";
        }
        else if (spacetime == 10)
        {
            Text_Plot5.GetComponent<Text>().text = "我就醒過來了 ";
        }
        else if (spacetime == 11)
        {
            Text_Plot5.GetComponent<Text>().text = "明明就沒說上幾句話 ";
        }
        else if (spacetime == 12)
        {
            Text_Plot5.GetComponent<Text>().text = "不過… ";
        }
        else if (spacetime == 13)
        {
            Text_Plot5.GetComponent<Text>().text = "其實媽從頭到尾都陪伴在我身邊呢 ";
        }
        else if (spacetime == 15)
        {
            Text_Plot5.GetComponent<Text>().text = "欣亞“媽…謝謝你” ";
        }
        else if (spacetime == 15)
        {
            Text_Plot5.GetComponent<Text>().text = "欣亞“對了，現在幾點了” ";
        }
        else if (spacetime == 16)
        {
            Text_Plot5.GetComponent<Text>().text = "欣亞“已經六點四十分了” ";
        }
        else if (spacetime == 17)
        {
            Text_Plot5.GetComponent<Text>().text = "欣亞“得趕快回家才行” ";
        }
        else if (spacetime == 18)
        {
            Text_Plot5.GetComponent<Text>().text = "“不然…”  ";
        }
        else if (spacetime == 19)
        {
            Text_Plot5.GetComponent<Text>().text = "我看向窗外 ";
        }
        else if (spacetime == 20)
        {
            Text_Plot5.GetComponent<Text>().text = "欣亞“不然媽會擔心的” ";
        }
        else if (spacetime == 21)
        {
            Text_Plot5.GetComponent<Text>().text = "我收拾桌上的文具，背上書包，走向門口 ";
        }
        else if (spacetime == 21)
        {
            Text_Plot5.GetComponent<Text>().text = "按住E跳過 ";
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
                Text_Plot6.GetComponent<Text>().text = "(Space繼續，如若跳過按住E跳過)";
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
            Text_Plot6.GetComponent<Text>().text = "欣亞“以後還是” ";
        }
        else if (spacetime2 == 2)
        {
            Text_Plot6.GetComponent<Text>().text = "欣亞“別留那麼晚吧” ";
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

