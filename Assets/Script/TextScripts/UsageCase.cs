using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RemptyTool.ES_MessageSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(ES_MessageSystem))]
public class UsageCase : MonoBehaviour
{
    private ES_MessageSystem msgSys;
    public UnityEngine.UI.Text uiText;
    public TextAsset textAsset;
    private List<string> textList = new List<string>();
    private int textIndex = 0;

    int count = 0;

    public float timer1=0f;
    bool isTimer=false;

    public int level = 0;
    public GameObject Image_cooldown;

    public Image cooldown;
    public bool coolingDown;
    public float waitTime = 3.0f;

    void Start()
    {
        Image_cooldown.SetActive(false);


        msgSys = this.GetComponent<ES_MessageSystem>();
        if (uiText == null)
        {
            Debug.LogError("UIText Component not assign.");
        }
        else
            ReadTextDataFromAsset(textAsset);

        //add special chars and functions in other component.
        msgSys.AddSpecialCharToFuncMap("UsageCase", CustomizedFunction);

        if (gameObject.name == "MsgSystem00")
        {
            level = 0;
        }
        else if (gameObject.name == "MsgSystem01")
        {
            level = 1;
        }
        else if (gameObject.name == "ExamText")
        {
            level = 2;
        }
        else if (gameObject.name == "Tobecontinue_level")
        {
            level = 3;
        }
    }

    private void CustomizedFunction()
    {
        Debug.Log("Hi! This is called by CustomizedFunction!");
    }

    private void ReadTextDataFromAsset(TextAsset _textAsset)
    {
        textList.Clear();
        textList = new List<string>();
        textIndex = 0;
        var lineTextData = _textAsset.text.Split('\n');
        foreach (string line in lineTextData)
        {
            textList.Add(line);
        }
    }

    void Update()
    {   

        if (Input.GetKeyDown(KeyCode.S))
        {
            //You can sending the messages from strings or text-based files.
            if (msgSys.IsCompleted)
            {
                msgSys.SetText("Send the messages![lr] HelloWorld![w]");
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Continue the messages, stoping by [w] or [lr] keywords.
            msgSys.Next();
        }

        //If the message is complete, stop updating text.
        if (msgSys.IsCompleted == false)
        {
            uiText.text = msgSys.text;
        }

        //Auto update from textList.
        if (msgSys.IsCompleted == true && textIndex < textList.Count)
        {
            msgSys.SetText(textList[textIndex]);
            textIndex++;
        }
        if (Input.GetKey(KeyCode.E))
        {
            Image_cooldown.SetActive(true);
            cooldown.fillAmount -= 1.0f / waitTime * Time.deltaTime;
            if (cooldown.fillAmount==0)
            {
                if (level == 0)
                {
                    SceneManager.LoadScene("Ch.1_Text");
                }
                else if (level == 1)
                {
                    SceneManager.LoadScene("All_Level");
                }
                else if (level == 2)
                {
                    SceneManager.LoadScene("All_Level");
                }
                else if (level == 3)
                {
                    Time.timeScale = 0;
                    SceneManager.LoadScene("Tobecontinue");
                }
            }

        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            cooldown.fillAmount += 1.0f;
            Image_cooldown.SetActive(false);
        }

    }
}
