using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;


// 신뢰도에 따른 Flowchart 호출 스크립트
public class randomflowchart : MonoBehaviour
{
    Conversation_flag cf;
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
        else if (SceneName.Equals("Office"))
        {
            reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability");
            Dylan_Reliability_Scene();
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
            Debug.Log("실행");
            int rand = Random.Range(1, 5);
            GameObject.Find("Flowchart_").transform.Find("Morethan60").transform.Find("Flowchart"+ rand).gameObject.SetActive(true);
            //GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Morethan60");

        }
        else if (reliability >= 0 && reliability < 60)
        {
            int rand = Random.Range(6, 9);
            GameObject.Find("Flowchart_").transform.Find("Lessthan60").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            //GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Lessthan60");
        }
    }
    // 신뢰도에 따른 힐다 Flowchart 호출
    public void Hilda_Reliability_Scene()
    {
        if (reliability >= 75 && reliability <= 100)
        {
            int rand = Random.Range(1, 3);
            GameObject.Find("Flowchart_").transform.Find("Morethan60").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
        }
        else if (reliability >= 0 && reliability < 75)
        {
            int rand = Random.Range(4, 6);
            GameObject.Find("Flowchart_").transform.Find("Lessthan60").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
        }
    }
    // 신뢰도에 따른 딜런 Flowchart 호출
    public void Dylan_Reliability_Scene()
    {
        if (reliability >= 75 && reliability <= 100)
        {
            int rand = Random.Range(1, 3);
            GameObject.Find("Flowchart_").transform.Find("Normal").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
        }
        //딜런은 호감도에 따른 대화 변경이 아닌 혁명루트에 따른 대화 변화
        /*else if (reliability >= 0 && reliability < 75)
        {
            int rand = Random.Range(4, 6);
            GameObject.Find("Flowchart_").transform.Find("Lessthan75").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
        }*/
        Debug.Log("딜런 대화 시작");
    }
    // 신뢰도에 따른 프랜시스 Flowchart 호출
    public void Frances_Reliability_Scene()
    {
        if (reliability >= 80 && reliability <= 100)
        {
            int rand = Random.Range(1, 3);
            GameObject.Find("Flowchart_").transform.Find("Morethan60").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
        }
        else if (reliability >= 0 && reliability < 80)
        {
            int rand = Random.Range(4, 6);
            GameObject.Find("Flowchart_").transform.Find("Lessthan60").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
        }
    }

}
