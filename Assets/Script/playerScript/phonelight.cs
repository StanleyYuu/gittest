using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phonelight : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)//¼²À»(¦º¤F³â)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("meeeeee hit enemy");

        }
    }
}
