using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static bool ploting;
    bool esc=false;
    public static bool restart=false;
    public GameObject m_panelConfirm;

    void Start()
    {
        ploting = false;
        m_panelConfirm.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            m_panelConfirm.SetActive(true);
            Cursor.visible = true;
            esc = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
        }
        if (!esc)
        {
            m_panelConfirm.SetActive(false);
        }
    }
    public void OnClick_Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void OnClick_Cancel()
    {
        esc = false;
        //m_panelConfirm.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        if (!ploting)
        {
            Time.timeScale = 1;
        }
    }
    public void OnClick_BackStart()
    {
        esc = false;
        restart = true;
        Time.timeScale = 1;
        SceneManager.LoadScene("StartMenu");
    }
}
