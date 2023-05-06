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
                Text_Plot.GetComponent<Text>().text = "(Space繼續，如若跳過按住E跳過)";
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
                Text_Plot.GetComponent<Text>().text = "欣亞“這裡是…校史室” ";
            }
            else if (spacetime == 2)
            {
                Text_Plot.GetComponent<Text>().text = "???“你們學校真多人才” ";
            }
            else if (spacetime == 3)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“是呢” ";
            }
            else if (spacetime == 4)
            {
                Text_Plot.GetComponent<Text>().text = "正當我看著琳琅滿目的獎杯時 ";
            }
            else if (spacetime == 5)
            {
                Text_Plot.GetComponent<Text>().text = "???“欣亞你有拿過獎盃嗎” ";
            }
            else if (spacetime == 6)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“沒有” ";
            }
            else if (spacetime == 7)
            {
                Text_Plot.GetComponent<Text>().text = "???“真的沒有嗎” ";
            }
            else if (spacetime == 8)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“真的沒有” ";
            }
            else if (spacetime == 9)
            {
                Text_Plot.GetComponent<Text>().text = "???“會不會又是你忘記了而已” ";
            }
            else if (spacetime == 10)
            {
                Text_Plot.GetComponent<Text>().text = "???“就像忘記芷瑄一樣” ";
            }
            else if (spacetime == 11)
            {
                Text_Plot.GetComponent<Text>().text = "聽到那聲音這麼一說 ";
            }
            else if (spacetime == 12)
            {
                Text_Plot.GetComponent<Text>().text = "我不禁思索了起來 ";
            }
            else if (spacetime == 13)
            {
                Text_Plot.GetComponent<Text>().text = "說不定我真的有拿過獎盃 ";
            }
            else if (spacetime == 14)
            {
                Text_Plot.GetComponent<Text>().text = "但我依然沒有頭緒 ";
            }
            else if (spacetime == 15)
            {
                Text_Plot.GetComponent<Text>().text = "欣亞“誰知道呢” ";
            }
            else if (spacetime == 16)
            {
                Text_Plot.GetComponent<Text>().text = "我冷淡地回應了那個聲音 ";
            }
            else if (spacetime == 17)
            {
                Text_Plot.GetComponent<Text>().text = "但我卻依稀覺得";
            }
            else if (spacetime == 18)
            {
                Text_Plot.GetComponent<Text>().text = "似乎真的有拿獎盃這回事 ";
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
