using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TobeMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick_Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void OnClick_Menu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
