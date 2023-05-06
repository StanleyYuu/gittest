using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DataSaver : MonoBehaviour
{
    public Scene m_Scene;
    public static DataSaver instance;
    GameObject player;
    string m_MyFirstScene;
    string m_MyFirstScene1;
    string m_MyFirstScene2;
    string m_MyFirstScene3;
    void Start()
    {
        m_Scene = SceneManager.GetActiveScene();
        m_MyFirstScene = "StartMenu";
        m_MyFirstScene1 = "DieMenu";
        m_MyFirstScene2 = "Level_00";
        m_MyFirstScene3 = "Level_02";
        if (instance != null || m_Scene.name == m_MyFirstScene || m_Scene.name == m_MyFirstScene1) 
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        if (m_Scene.name != m_MyFirstScene2)
        {
            DontDestroyOnLoad(gameObject);
        }

    }
    private void Update()
    {
        m_Scene = SceneManager.GetActiveScene();

        if (m_Scene.name != m_MyFirstScene&& m_Scene.name != m_MyFirstScene && m_Scene.name != m_MyFirstScene1&& m_Scene.name != m_MyFirstScene2)
        {
            DontDestroyOnLoad(gameObject);
        }
        else if(m_Scene.name != m_MyFirstScene2)
        {
            Destroy(gameObject);
        }

    }
}
