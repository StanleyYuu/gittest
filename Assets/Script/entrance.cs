using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entrance : MonoBehaviour
{
    public string entrancepassword;
    private void Start()
    {
        if (Player.instance.scenepassword == entrancepassword)
        {
            //Debug.Log("Enter!");
            Player.instance.transform.position = transform.position;
        }
        else
        {
            //Debug.Log("");
        }
    }
}