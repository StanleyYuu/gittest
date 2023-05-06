using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LastScenes : MonoBehaviour
{
    int click_time;
    public GameObject m_one;
    public GameObject m_two;
    public GameObject m_three;
    void Start()
    {
        click_time = 0;
        m_one.SetActive(true);
        m_two.SetActive(false);
        m_three.SetActive(false);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            click_time++;
        }
        if (click_time==1)
        {
            m_two.SetActive(true);
        }
        if (click_time == 2)
        {
            m_three.SetActive(true);
        }
    }
}
