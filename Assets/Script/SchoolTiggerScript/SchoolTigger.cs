//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;
//using System.IO;

//public class SchoolTigger : MonoBehaviour
//{
//    public GameObject m_paperF;
//    public GameObject m_paperget;
//    public GameObject m_Fireget;
//    public GameObject m_Paper;
//    public GameObject m_FireF;
//    public GameObject m_Fire;
//    public static bool FireF_ed = true;
//    public static bool F_ed = true;
//    public static bool getpaper = false;
//    public static bool getFire = false;
//    void Start()
//    {
//        m_paperF.SetActive(false);
//        m_paperget.SetActive(false);
//        m_Fireget.SetActive(false);
//        m_FireF.SetActive(false);
//    }
//    void Update()
//    {
//        if (Player.paper == true && F_ed == true)
//        {
//            m_paperF.SetActive(true);
//        }
//        if ((Input.GetKeyDown(KeyCode.F)) && Player.paper == true)
//        {
//            getpaper = true;
//            m_paperF.SetActive(false);
//            F_ed = false;
//            m_paperget.SetActive(true);
//            m_Paper.SetActive(false);
//            m_paperF.SetActive(false);
//            if (Player.paper == true)
//            {
//                m_Paper.SetActive(false);
//            }
//        }
//        if (Player.fire == false)
//        {
//            m_FireF.SetActive(false);
//        }
//        if (Player.paper == false)
//        {
//            m_paperF.SetActive(false);
//        }

//        if (Player.fire == true && FireF_ed == true)
//        {
//            m_FireF.SetActive(true);
//        }
//        if ((Input.GetKeyDown(KeyCode.F)) && Player.fire == true)
//        {
//            m_FireF.SetActive(false);
//            FireF_ed = false;
//            m_Fire.SetActive(false);
//            m_FireF.SetActive(false);
//            if (Player.fire == true)
//            {
//                m_Fire.SetActive(false);
//                m_Fireget.SetActive(true);
//            }
//        }
//    }
//}
