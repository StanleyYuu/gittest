using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phonelight : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)//����(���F��)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("meeeeee hit enemy");

        }
    }
}
