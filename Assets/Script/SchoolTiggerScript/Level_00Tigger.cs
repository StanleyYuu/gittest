using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_00Tigger : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;
    public string scenename;
    public GameObject TheFtext;
    public GameObject KeyObject;
    public GameObject DoorText;
    public GameObject DoorText1;
    public static bool classKeyED=false;
    void Start()
    {
        classKeyED = false;
        KeyObject.SetActive(true);
        TheFtext.SetActive(false);
        DoorText.SetActive(false);
        DoorText1.SetActive(false);
        DoorText.SetActive(false);
    }
    void Update()
    {
        if (Player.The_00_Key==true&&classKeyED==false)
        {
            Debug.Log("123");
            TheFtext.SetActive(true);
            if ((Input.GetKeyDown(KeyCode.F)))
            {
                classKeyED = true;
                KeyObject.gameObject.GetComponent<Renderer>().enabled = false;
            }
        }
        else
            TheFtext.SetActive(false);
        if (Player.HitDoor1==true)
        {
            DoorText.SetActive(true);
        }
        else
            DoorText.SetActive(false);
        if (Player.HitDoor == true)
        {
            DoorText1.SetActive(true);
            if ((Input.GetKeyDown(KeyCode.F)))
            {
                thePlayer = GameObject.Find("¹qµ©¥\¯à");
                thePlayer.transform.position = teleportTarget.transform.position;
            }
        }
        else
            DoorText1.SetActive(false);
    }   
}
