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
            Text_Plot.GetComponent<Text>().text = "(Space繼續，如若跳過按住E跳過)";
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
                Text_Plot.GetComponent<Text>().text = "???“好了，這些紙應該夠了” ";
            }
            else if (spacetime == 2)
            {
                Text_Plot.GetComponent<Text>().text = "???“馬上來摺摺看吧” ”";
            }
            else if (spacetime == 3)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“知道了” ";
            }
            else if(spacetime == 4)
            {
                Text_Plot.GetComponent<Text>().text = "第一頁，是紙花 ";
            }
            else if (spacetime == 5)
            {
                Text_Plot.GetComponent<Text>().text = "雖然不難摺，但卻飽含著心意 ";
            }
            else if (spacetime == 6)
            {
                Text_Plot.GetComponent<Text>().text = "???“這是芷瑄在你生日時送給你的” ";
            }
            else if (spacetime == 7)
            {
                Text_Plot.GetComponent<Text>().text = "芷瑄“欣亞，祝你生日快樂” ";
            }
            else if (spacetime == 8)
            {
                Text_Plot.GetComponent<Text>().text = "芷瑄“這是送你的” ";
            }
            else if (spacetime == 9)
            {
                Text_Plot.GetComponent<Text>().text = "芷瑄每年都會送我相應年齡的紙花束  ";
            }
            else if (spacetime == 10)
            {
                Text_Plot.GetComponent<Text>().text = "而且一年比一年更加華麗 ";
            }
            else if (spacetime == 11)
            {
                Text_Plot.GetComponent<Text>().text = "不知道她摺了多久? ";
            }
            else if (spacetime == 12)
            {
                Text_Plot.GetComponent<Text>().text = "第二頁，是聖誕樹 ";
            }
            else if (spacetime == 13)
            {
                Text_Plot.GetComponent<Text>().text = "折好之後看上去挺樸素的 ";
            }
            else if (spacetime == 14)
            {
                Text_Plot.GetComponent<Text>().text = "但是… ";
            }
            else if (spacetime == 15)
            {
                Text_Plot.GetComponent<Text>().text = "???“這是芷瑄送你的交換禮物” ";
            }
            else if (spacetime == 16)
            {
                Text_Plot.GetComponent<Text>().text = "芷瑄“聖誕快樂，欣亞” ";
            }
            else if (spacetime == 17)
            {
                Text_Plot.GetComponent<Text>().text = "芷瑄“這個要小心拿，不難會散掉的” ";
            }
            else if (spacetime == 18)
            {
                Text_Plot.GetComponent<Text>().text = "但是芷瑄都會自己畫上點綴 ";
            }
            else if (spacetime == 19)
            {
                Text_Plot.GetComponent<Text>().text = "還在上面加星星之類的裝飾 ";
            }
            else if (spacetime == 20)
            {
                Text_Plot.GetComponent<Text>().text = "簡直像是藝術品 ";
            }
            else if (spacetime == 21)
            {
                Text_Plot.GetComponent<Text>().text = "反觀我送了什麼呢? ";
            }
            else if (spacetime == 22)
            {
                Text_Plot.GetComponent<Text>().text = "第三頁，是紙鶴 ";
            }
            else if (spacetime == 23)
            {
                Text_Plot.GetComponent<Text>().text = "這對我來說有點難 ";
            }
            else if (spacetime == 24)
            {
                Text_Plot.GetComponent<Text>().text = "沒有看書是摺不出來的 ";
            }
            else if (spacetime == 25)
            {
                Text_Plot.GetComponent<Text>().text = "???“這是國中畢業時，芷瑄送你的” ";
            }
            else if (spacetime == 26)
            {
                Text_Plot.GetComponent<Text>().text = "???“欣亞，你要去哪裡”";
            }
            else if (spacetime == 27)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“一定有毀掉他的方法”";
            }
            else if (spacetime == 28)
            {
                Text_Plot.GetComponent<Text>().text = "芷瑄“畢業了呢欣亞” ";
            }
            else if (spacetime == 29)
            {
                Text_Plot.GetComponent<Text>().text = "芷瑄“我們是同一所高中對吧” ";
            }
            else if (spacetime == 30)
            {
                Text_Plot.GetComponent<Text>().text = "芷瑄“不知道我們會不會又是同班同學” ";
            }
            else if (spacetime == 31)
            {
                Text_Plot.GetComponent<Text>().text = "芷瑄從書包裡拿出一對紙鶴 ";
            }
            else if (spacetime == 32)
            {
                Text_Plot.GetComponent<Text>().text = "然後放進我的手心 ";
            }
            else if (spacetime == 33)
            {
                Text_Plot.GetComponent<Text>().text = "芷瑄“不管是不是同班，你都是我最要好的朋友喔” ";
            }
            else if (spacetime == 34)
            {
                Text_Plot.GetComponent<Text>().text = "芷瑄“對吧，欣亞” ";
            }
            else if (spacetime == 35)
            {
                Text_Plot.GetComponent<Text>().text = "我都想起來了 ";
            }
            else if (spacetime == 36)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“芷瑄…” ";
            }
            else if (spacetime == 37)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“陳芷瑄…是我的朋友” ";
            }
            else if (spacetime == 38)
            {
                Text_Plot.GetComponent<Text>().text = "???“沒錯” ";
            }
            else if (spacetime == 39)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“為什麼我會忘記最好的朋友” ";
            }
            else if (spacetime == 40)
            {
                Text_Plot.GetComponent<Text>().text = "???“繼續走你就會知道了” ";
            }
            else if (spacetime == 41)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“好吧” ";
            }
            else if (spacetime == 42)
            {
                Text_Plot.GetComponent<Text>().text = "我走向往一樓的樓梯 ";
            }
            else if (spacetime == 43)
            {
                Text_Plot.GetComponent<Text>().text = "芷瑄… ";
            }
            else if (spacetime == 44)
            {
                Text_Plot.GetComponent<Text>().text = "等我回去再教我摺紙吧 ";
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
