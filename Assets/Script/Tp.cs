using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;
    private void OnTriggerEnter(Collider other)
    {
        thePlayer = GameObject.Find("�q���\��");
        thePlayer.transform.position = teleportTarget.transform.position;
    }
}
