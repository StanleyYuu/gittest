using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieMenu : MonoBehaviour
{
    public static bool restart = false;
    public void OnClick_backtostart()
    {
        Time.timeScale = 1;
        restart = true;
        SceneManager.LoadScene("StartMenu");
    }
    public void OnClick_again()
    {
        SceneManager.LoadScene("Level_02");
        Time.timeScale = 1;
    }
}
