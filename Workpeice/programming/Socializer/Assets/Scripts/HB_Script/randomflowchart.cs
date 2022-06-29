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
    bool Revolutionary_route;

    void Start()
    {
        SceneName = SceneManager.GetActiveScene().name;
        Debug.Log("randomflowchart 스크립트, 장소 : " + SceneName);

        Revolutionary_route = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Revolutionary_route");
        if (SceneName.Equals("House"))
        {
            reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability");
            Heather_Reliability_Scene();
        }
        else if (SceneName.Equals("Lobby"))
        {
            reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability");
            Hilda_Reliability_Scene();
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

    // 헤더(딸) Flowchart 호출
    public void Heather_Reliability_Scene()
    {
        // 헤더, 프랜시스는 신뢰도에 따라 대화 변화가 이뤄짐
        Debug.Log(reliability);
        if (reliability >= 60 && reliability <= 100)
        {
            Debug.Log("실행");
            int rand = Random.Range(1, 6);
            GameObject.Find("Flowchart_").transform.Find("Morethan60").transform.Find("Flowchart"+ rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Morethan60", SceneName);

        }
        else if (reliability >= 0 && reliability < 60)
        {
            int rand = Random.Range(6, 10);
            GameObject.Find("Flowchart_").transform.Find("Lessthan60").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Lessthan60", SceneName);
        }
    }
    // 힐다 Flowchart 호출
    public void Hilda_Reliability_Scene()
    {
        //힐다, 딜런은 호감도에 따른 대화 변경이 아닌 혁명루트에 따른 대화 변화
        if (Revolutionary_route == false)
        {
            int rand = Random.Range(1, 8);
            GameObject.Find("Flowchart_").transform.Find("Normal").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Normal", SceneName);
        }
        else if (Revolutionary_route == true)
        {
            int rand = Random.Range(8, 10);// 대사 추가시 수정 요구
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Revolutionary_route", SceneName);
        }
        /*
        if (Revolutionary_route == false)
        {
            int rand = Random.Range(1, 8);
            GameObject.Find("Flowchart_").transform.Find("Morethan60").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Normal", SceneName);
        }
        else if (Revolutionary_route == true)
        {
            int rand = Random.Range(8, 10);// 대사 추가시 수정 요구
            GameObject.Find("Flowchart_").transform.Find("Lessthan60").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Revolutionary_route", SceneName);
        }*/
    }
    // 딜런 Flowchart 호출
    public void Dylan_Reliability_Scene()
    {
        //힐다, 딜런은 호감도에 따른 대화 변경이 아닌 혁명루트에 따른 대화 변화
        if (Revolutionary_route == false)
        {
            int rand = Random.Range(1, 6);
            GameObject.Find("Flowchart_").transform.Find("Normal").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Normal", SceneName);
        }
        else if (Revolutionary_route == true)
        {
            int rand = Random.Range(6, 10);
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Revolutionary_route", SceneName);
        }
        Debug.Log("딜런 대화 시작");
    }
    // 프랜시스 Flowchart 호출
    public void Frances_Reliability_Scene()
    {
        // 헤더, 프랜시스는 신뢰도에 따라 대화 변화가 이뤄짐
        //if (reliability >= 80 && reliability <= 100)
        if (Revolutionary_route == false)
        {
            int rand = Random.Range(1, 8);
            GameObject.Find("Flowchart_").transform.Find("Morethan80").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Morethan80", SceneName);
        }
        else if (Revolutionary_route == true)
        {
            int rand = Random.Range(8, 10);// 혁명 루트 추가시 수정 요구
            GameObject.Find("Flowchart_").transform.Find("Lessthan80").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Lessthan80", SceneName);
        }
    }

}
