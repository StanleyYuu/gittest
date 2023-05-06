using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public string scenename;
    [SerializeField] private string newscenepassword;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player.instance.scenepassword = newscenepassword;
            SceneManager.LoadScene(scenename);

            //记录LOADING场景中需要读取的C场景名称
            Globe.scencename = (scenename);
            //先进入B场景
            SceneManager.LoadScene("Loading");
        }
    }
}