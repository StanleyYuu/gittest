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
        thePlayer = GameObject.Find("電筒功能");
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
            Text_Plot4.GetComponent<Text>().text = "(Space繼續，如若跳過按住E跳過)";
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
                Text_Plot4.GetComponent<Text>().text = "我閃躲心怪的追擊並來到舞台上 ";
            }
            else if (spacetime == 2)
            {
                Text_Plot4.GetComponent<Text>().text = "然後拿起獎盃 ";
            }
            else if (spacetime == 3)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“這到底是…” ";
            }
            else if (spacetime == 4)
            {
                Text_Plot4.GetComponent<Text>().text = "我看向獎盃的主人 ";
            }
            else if (spacetime == 5)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“李…欣亞…” ";
            }
            else if (spacetime == 6)
            {
                Text_Plot4.GetComponent<Text>().text = "李欣亞，2020青少年舞蹈比賽，第四名 ";
            }
            else if (spacetime == 7)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“這是我的獎盃嗎” ";
            }
            else if (spacetime == 8)
            {
                Text_Plot4.GetComponent<Text>().text = "???“沒錯” ";
            }
            else if (spacetime == 9)
            {
                Text_Plot4.GetComponent<Text>().text = "???“你還記得嗎” ";
            }
            else if (spacetime == 10)
            {
                Text_Plot4.GetComponent<Text>().text = "???“國中畢業那年的暑假參加了舞蹈比賽” ";
            }
            else if (spacetime == 11)
            {
                Text_Plot4.GetComponent<Text>().text = "???“最後拿到第四名” ";
            }
            else if (spacetime == 12)
            {
                Text_Plot4.GetComponent<Text>().text = "???“但是回家之後…” ";
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
                Text_Plot4.GetComponent<Text>().text = "欣亞的爸爸“不過才拿第四名而已” ";
            }
            else if (spacetime == 17)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“什麼…” ";
            }
            else if (spacetime == 18)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞的爸爸“只拿到這種成績不如別跳了” ";
            }
            else if (spacetime == 19)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞的爸爸“上高中之後你哪來的時間跳” ";
            }
            else if (spacetime == 20)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞的爸爸“不如早點放棄吧” ";
            }
            else if (spacetime == 21)
            {
                Text_Plot4.GetComponent<Text>().text = "我回到了房間 ";
            }
            else if (spacetime == 22)
            {
                Text_Plot4.GetComponent<Text>().text = "把獎盃砸到了牆上";
            }
            else if (spacetime == 23)
            {
                Text_Plot4.GetComponent<Text>().text = "我爸很反對我去跳舞";
            }
            else if (spacetime == 24)
            {
                Text_Plot4.GetComponent<Text>().text = "原本想著要是得名的話";
            }
            else if (spacetime == 25)
            {
                Text_Plot4.GetComponent<Text>().text = "我爸說不定就會改觀 ";
            }
            else if (spacetime == 26)
            {
                Text_Plot4.GetComponent<Text>().text = "但結果卻是如此";
            }
            else if (spacetime == 27)
            {
                Text_Plot4.GetComponent<Text>().text = "我好恨我爸 ";
            }
            else if (spacetime == 28)
            {
                Text_Plot4.GetComponent<Text>().text = "但我更恨試圖改變他想法的我";
            }
            else if (spacetime == 29)
            {
                Text_Plot4.GetComponent<Text>().text = "想想還真是可悲呢";
            }
            else if (spacetime == 30)
            {
                Text_Plot4.GetComponent<Text>().text = "從那之後我就沒再跳舞了 ";
            }
            else if (spacetime == 31)
            {
                Text_Plot4.GetComponent<Text>().text = "轉而埋首讀書";
            }
            else if (spacetime == 32)
            {
                Text_Plot4.GetComponent<Text>().text = "試圖用另一種方法來讓他認同我 ";
            }
            else if (spacetime == 33)
            {
                Text_Plot4.GetComponent<Text>().text = "但是我都已經高二了";
            }
            else if (spacetime == 34)
            {
                Text_Plot4.GetComponent<Text>().text = "成績依然沒有起色 ";
            }
            else if (spacetime == 35)
            {
                Text_Plot4.GetComponent<Text>().text = "唉…";
            }
            else if (spacetime == 36)
            {
                Text_Plot4.GetComponent<Text>().text = "我就是這樣的人 ";
            }
            else if (spacetime == 37)
            {
                Text_Plot4.GetComponent<Text>().text = "什麼都做不好 ";
            }
            else if (spacetime == 38)
            {
                Text_Plot4.GetComponent<Text>().text = "???“不…” ";
            }
            else if (spacetime == 39)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“嗯?” ";

            }
            else if (spacetime == 40)
            {
                Text_Plot4.GetComponent<Text>().text = "???“不是的…” ";
            }
            else if (spacetime == 41)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“這聲音是?” ";
            }
            else if (spacetime == 42)
            {
                Text_Plot4.GetComponent<Text>().text = "???“不是這樣的，欣亞” ";
            }
            else if (spacetime == 43)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“不然是怎麼樣” ";
            }
            else if (spacetime == 44)
            {
                Text_Plot4.GetComponent<Text>().text = "???“你誤會爸爸了” ";
            }
            else if (spacetime == 45)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“誤會?” ";
            }
            else if (spacetime == 46)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“在他否定我的努力之後，你還覺得我誤會他嗎” ";
            }
            else if (spacetime == 47)
            {
                Text_Plot4.GetComponent<Text>().text = "???“其實爸爸他以前…” ";
            }
            else if (spacetime == 48)
            {
                Text_Plot4.GetComponent<Text>().text = "???“…也是個舞者” ";
            }
            else if (spacetime == 49)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“什麼?” ";
            }
            else if (spacetime == 50)
            {
                Text_Plot4.GetComponent<Text>().text = "???“爸爸在你出生前受過嚴重的傷” ";
            }
            else if (spacetime == 51)
            {
                Text_Plot4.GetComponent<Text>().text = "???“這讓他不能再做劇烈運動” ";
            }
            else if (spacetime == 52)
            {
                Text_Plot4.GetComponent<Text>().text = "???“他只是不希望你有跟他一樣的遭遇” ";
            }
            else if (spacetime == 53)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“那又怎樣”";
            }
            else if (spacetime == 54)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“這不是他否定我的藉口” ";
            }
            else if (spacetime == 55)
            {
                Text_Plot4.GetComponent<Text>().text = "???“你每次比賽時” ";
            }
            else if (spacetime == 56)
            {
                Text_Plot4.GetComponent<Text>().text = "???“爸爸都會在角落看著你” ";
            }
            else if (spacetime == 57)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“……” ";
            }
            else if (spacetime == 58)
            {
                Text_Plot4.GetComponent<Text>().text = "???“爸爸心底是很關心你的” ";
            }
            else if (spacetime == 59)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“爸…” ";
            }
            else if (spacetime == 60)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“為什麼…” ";
            }
            else if (spacetime == 61)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“為什麼要告訴我這些” ";
            }
            else if (spacetime == 62)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“你到底是誰” ";
            }
            else if (spacetime == 63)
            {
                Text_Plot4.GetComponent<Text>().text = "???“兩個人個性都一樣，果然是父女呢” ";
            }
            else if (spacetime == 64)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“難…難道…” ";
            }
            else if (spacetime == 65)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“媽…” ";
            }
            else if (spacetime == 66)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“是你嗎…” ";
            }
            else if (spacetime == 67)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞的媽媽“欣亞，很抱歉這麼早就離開了你” ";
            }
            else if (spacetime == 68)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞的媽媽“讓你獨自面對這些” ";
            }
            else if (spacetime == 69)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞的媽媽“但是媽媽可是很支持你的喔” ";
            }
            else if (spacetime == 70)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞的媽媽“所以” ";
            }
            else if (spacetime == 71)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞的媽媽“看在媽媽的份上，跟爸爸和好吧” ";
            }
            else if (spacetime == 72)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“我…” ";
            }
            else if (spacetime == 73)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“我不知道…” ";
            }
            else if (spacetime == 74)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞的媽媽“拜託你了，欣亞” ";
            }
            else if (spacetime == 75)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“我會…試試看…” ";
            }
            else if (spacetime == 76)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞的媽媽“謝謝你，欣亞” ";
            }
            else if (spacetime == 78)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞的媽媽“時間差不多了” ";
            }
            else if (spacetime == 79)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞的媽媽“欣亞你也該醒來了” ";
            }
            else if (spacetime == 80)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“媽…你要走了嗎?” ";
            }
            else if (spacetime == 81)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞的媽媽“欣亞，要記得” ";
            }
            else if (spacetime == 82)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞的媽媽“我會一直守護你們的” ";
            }
            else if (spacetime == 83)
            {
                Text_Plot4.GetComponent<Text>().text = "欣亞“媽…等等…” ";
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

