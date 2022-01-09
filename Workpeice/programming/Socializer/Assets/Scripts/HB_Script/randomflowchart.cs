using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;


// 신뢰도에 따른 Flowchart 호출 스크립트
public class randomflowchart : MonoBehaviour
{
    float reliability;// 호감도에 따른 다른 대화 호출
    string SceneName;// 씬이름 구별

    void Start()
    {
        SceneName = SceneManager.GetActiveScene().name;

        if (SceneName.Equals("House"))
        {
            reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability");
            Heather_Reliability_Scene();
        }
        else if (SceneName.Equals("Lobby"))
        {
            reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability");
        }
        else if (SceneName.Equals("AM"))
        {
            reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability");
            Frances_Reliability_Scene();
        }

    }

    // 신뢰도에 따른 헤더(딸) Flowchart 호출
    public void Heather_Reliability_Scene()
    {
        Debug.Log(reliability);
        if (reliability >= 60 && reliability <= 100)
        {
            int rand = Random.Range(1, 3);
            GameObject.Find("Flowchart_").transform.Find("Morethan60").transform.Find("Flowchart1"/* + rand*/).gameObject.SetActive(true);
        }
        else if (reliability >= 0 && reliability < 60)
        {
            int rand = Random.Range(4, 6);
            GameObject.Find("Flowchart_").transform.Find("Lessthan60").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
        }
    }
    // 신뢰도에 따른 프랜시스 Flowchart 호출
    public void Frances_Reliability_Scene()
    {
        if (reliability >= 80 && reliability <= 100)
        {
            int rand = Random.Range(1, 3);
            GameObject.Find("Random_Flowchart").transform.Find("Morethan60").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
        }
        else if (reliability >= 0 && reliability < 80)
        {
            int rand = Random.Range(4, 6);
            GameObject.Find("Random_Flowchart").transform.Find("Lessthan60").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
        }
    }
}
