using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BG_Reliability : MonoBehaviour
{
    float Hilda_reliability;
    float Heather_reliability;
    float Frances_reliability;
    float Dylan_reliability;
    string SceneName;// 씬이름 구별

    void Start()
    {
        Heather_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability");
        Dylan_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability");
        SetBG();
    }

    public void SetBG()
    {
        SceneName = SceneManager.GetActiveScene().name;

        if (SceneName.Equals("House"))
        {
            //Debug.Log(Heather_reliability);
            if (Heather_reliability > 60)
            {
                GameObject.Find("BG").transform.Find("집").gameObject.SetActive(true);
            }
            else if(Heather_reliability <= 60)
            {
                GameObject.Find("BG").transform.Find("집_호감도 변경").gameObject.SetActive(true);
            }
        }

        else if (SceneName.Equals("Office"))
        {
            if (Heather_reliability > 60)
            {
                GameObject.Find("BG").transform.Find("사무실").gameObject.SetActive(true);
            }
            else if (Heather_reliability <= 60)
            {
                GameObject.Find("BG").transform.Find("사무실_호감도 변경").gameObject.SetActive(true);
            }
        }
    }
}
