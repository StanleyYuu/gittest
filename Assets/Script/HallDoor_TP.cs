using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallDoor_TP : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;
    public GameObject Hall_F_Text;
    bool F_ED;
    bool hit;
    bool tped;
    void Start()
    {
        Hall_F_Text.SetActive(false);
        thePlayer = GameObject.Find("¹qµ©¥\¯à");
        F_ED = false;
        hit = false;
        tped = false;
    }
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.F) && !F_ED&&HistoryRoom.F_ed&&hit))//
        {
            Hall_F_Text.SetActive(false);
            F_ED = true;
        }
        if (F_ED&&!tped)//
        {
            tped = true;
            thePlayer.transform.position = teleportTarget.transform.position;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        hit = true;
        if (!F_ED)
        {
            Hall_F_Text.SetActive(true);
        }
    }
}
