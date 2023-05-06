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
                Text_Plot.GetComponent<Text>().text = "(Space繼續，如若跳過按住E跳過)";
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
                Text_Plot.GetComponent<Text>().text = "欣亞“這是...” ";
            }
            else if (spacetime == 2)
            {
                Text_Plot.GetComponent<Text>().text = "我看到與架子上其他書不同的一本書 ";
            }
            else if (spacetime == 3)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“摺紙…大全” ";
            }
            else if (spacetime == 4)
            {
                Text_Plot.GetComponent<Text>().text = "???“文學社裡怎麼會放這本書” ";
            }
            else if (spacetime == 5)
            {
                Text_Plot.GetComponent<Text>().text = "我翻開書 ";
            }
            else if (spacetime == 6)
            {
                Text_Plot.GetComponent<Text>().text = "看到第一頁寫著一個名字 ";
            }
            else if (spacetime == 7)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“陳…芷瑄…” ";
            }
            else if (spacetime == 8)
            {
                Text_Plot.GetComponent<Text>().text = "感覺好熟悉的名字… ";
            }
            else if (spacetime == 9)
            {
                Text_Plot.GetComponent<Text>().text = "???“你不認識嗎?” ";
            }
            else if (spacetime == 10)
            {
                Text_Plot.GetComponent<Text>().text = "???“陳芷瑄是你的朋友啊” ";
            }
            else if (spacetime == 11)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“嗯?";
            }
            else if (spacetime == 12)
            {
                Text_Plot.GetComponent<Text>().text = "朋友?我有這種東西嗎? ";
            }
            else if (spacetime == 13)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“不可能，我才沒有…” ";
            }
            else if (spacetime == 14)
            {
                Text_Plot.GetComponent<Text>().text = "???“有的” ";
            }
            else if (spacetime == 15)
            {
                Text_Plot.GetComponent<Text>().text = "???“你只是現在想不起來罷了” ";
            }
            else if (spacetime == 16)
            {
                Text_Plot.GetComponent<Text>().text = "???“你們從小就認識了 ";
            }
            else if (spacetime == 17)
            {
                Text_Plot.GetComponent<Text>().text = "???“就連現在也在同一班呢” ";
            }
            else if (spacetime == 18)
            {
                Text_Plot.GetComponent<Text>().text = "我再仔細看了第一頁 ";
            }
            else if (spacetime == 19)
            {
                Text_Plot.GetComponent<Text>().text = "二年五班，陳芷瑄 ";
            }
            else if (spacetime == 20)
            {
                Text_Plot.GetComponent<Text>().text = "???“對吧” ";
            }
            else if (spacetime == 21)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“唔…” ";
            }
            else if (spacetime == 22)
            {
                Text_Plot.GetComponent<Text>().text = "記憶好模糊，像是忘了什麼一樣 ";
            }
            else if (spacetime == 23)
            {
                Text_Plot.GetComponent<Text>().text = "???“芷瑄最愛的就是摺紙” ";
            }
            else if (spacetime == 24)
            {
                Text_Plot.GetComponent<Text>().text = "???“在聖誕節和你生日的時候他都送你摺紙當禮物” ";
            }
            else if (spacetime == 25)
            {
                Text_Plot.GetComponent<Text>().text = "???“欣亞，你不記得了嗎” ";
            }
            else if (spacetime == 26)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“我…不知道…” ";
            }
            else if (spacetime == 27)
            {
                Text_Plot.GetComponent<Text>().text = "這種說不出來的感覺是什麼? ";
            }
            else if (spacetime == 28)
            {
                Text_Plot.GetComponent<Text>().text = "???“這樣好了” ";
            }
            else if (spacetime == 29)
            {
                Text_Plot.GetComponent<Text>().text = "???“不如你也折幾個摺紙” ";
            }
            else if (spacetime == 30)
            {
                Text_Plot.GetComponent<Text>().text = "???“說不定這樣就會想起來了” ";
            }
            else if (spacetime == 31)
            {
                Text_Plot.GetComponent<Text>().text = "我想了想 ";
            }
            else if (spacetime == 32)
            {
                Text_Plot.GetComponent<Text>().text = "“…就這麼辦吧” ";
            }
            else if (spacetime == 33)
            {
                Text_Plot.GetComponent<Text>().text = "… ";
            }
            else if (spacetime == 34)
            {
                Text_Plot.GetComponent<Text>().text = "芷…瑄…";
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
