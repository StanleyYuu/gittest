using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CabinetPlot : MonoBehaviour
{
    public bool coolingDown;
    int spacetime;
    bool watched;
    bool F_ed;
    public GameObject Image_cooldown;
    public GameObject Text_Plot;
    public GameObject TextImage;
    public GameObject Ftext;
    public Image CoolDown;
    void Start()
    {
        watched = false;
        Text_Plot = GameObject.Find("Plot_Text");
        TextImage = GameObject.Find("TextImage");
        CoolDown = GameObject.Find("CoolDown").GetComponent<Image>();
        Image_cooldown = GameObject.Find("CoolDown");
        Ftext = GameObject.Find("CabinetPlot_F_text");
        Image_cooldown.SetActive(false);
        Text_Plot.SetActive(false);
        TextImage.SetActive(false);
        Ftext.SetActive(false);
    }

    void Update()
    {
        if (Player.hit_Cabinet&& Player.watchedRoomPlotUi && !watched)
        {
            Ftext.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                watched = true;
                Ftext.SetActive(false);
                MainMenu.ploting = true;
                Text_Plot.GetComponent<Text>().text = "(Space繼續，如若跳過按住E跳過)";
                Text_Plot.SetActive(true);
                TextImage.SetActive(true);
                F_ed = true;
                Time.timeScale = 0;
            }
        }
        else
            Ftext.SetActive(false);
        if (Input.GetKey(KeyCode.E) && F_ed && !Player.watchedCabinetPlot)
        {
            Image_cooldown.SetActive(true);
            CoolDown.fillAmount -= 0.01f;
            if (CoolDown.fillAmount == 0)
            {
                spacetime = 12;
                Image_cooldown.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && F_ed && !Player.watchedCabinetPlot)
        {
            spacetime++;
        }
        if (spacetime == 1)
        {
            Text_Plot.GetComponent<Text>().text = "欣亞“這裡怎麼空了” ";
        }
        else if (spacetime == 2)
        {
            Text_Plot.GetComponent<Text>().text = "???““你知道這邊原本放什麼獎盃嗎” ";
        }
        else if (spacetime == 3)
        {
            Text_Plot.GetComponent<Text>().text = "欣亞“不知道” ";
        }
        else if (spacetime == 4)
        {
            Text_Plot.GetComponent<Text>().text = "???“去找找看怎麼樣” ";
        }
        else if (spacetime == 5)
        {
            Text_Plot.GetComponent<Text>().text = "欣亞“為什麼” ";
        }
        else if (spacetime == 6)
        {
            Text_Plot.GetComponent<Text>().text = "???“反正也沒事不是嗎” ";
        }
        else if (spacetime == 7)
        {
            Text_Plot.GetComponent<Text>().text = "欣亞“真麻煩” ";
        }
        else if (spacetime == 8)
        {
            Text_Plot.GetComponent<Text>().text = "???“說不定欣亞會想起什麼喔” ";
        }
        else if (spacetime == 9)
        {
            Text_Plot.GetComponent<Text>().text = "還挺有道理的 ";
        }
        else if (spacetime == 10)
        {
            Text_Plot.GetComponent<Text>().text = "欣亞“好吧” ";
        }
        else if (spacetime == 11)
        {
            Text_Plot.GetComponent<Text>().text = "去找找獎盃的下落吧 ";
        }
        else if (spacetime == 12)
        {   
            Text_Plot.SetActive(false);
            TextImage.SetActive(false);
            Time.timeScale = 1;
            MainMenu.ploting = false;
            Player.watchedCabinetPlot = true;
            spacetime ++;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            CoolDown.fillAmount += 1.0f;
            Image_cooldown.SetActive(false);
        }
        
    }
}
