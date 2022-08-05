using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;


// 신뢰도에 따른 Flowchart 호출 스크립트
public class randomflowchart : MonoBehaviour
{
    Fadeout _fadeout;
    float reliability;// 호감도에 따른 다른 대화 호출
    string SceneName;// 씬이름 구별
    bool Revolutionary_route;
    RandomNPC _randomNPC;

    int Day;

    void Start()
    {
        _fadeout = FindObjectOfType<Fadeout>();
        Day = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Day");
        SceneName = SceneManager.GetActiveScene().name;
        Debug.Log("randomflowchart 스크립트, 장소 : " + SceneName);
        _randomNPC = FindObjectOfType<RandomNPC>();

        Revolutionary_route = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Revolutionary_route");
        if (SceneName.Equals("House"))
        {
            reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability");
            if (Day == 1)
            {
                Heather_Day1();
            }
            else if(Day == 4)
            {
                Heather_Day4();
            }
            else
            {
                Heather_Reliability_Scene();
            }
        }// 집 수정 필요
        else if (SceneName.Equals("Lobby"))
        {
            reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability");
            
            if (Day == 3)
            {
                Hilda_Day3();
            }
            else
            {
                Hilda_Reliability_Scene();
            }
        }//로비 수정 필요
        else if (SceneName.Equals("Office"))
        {
            reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability");
            
            if (Day == 1 || Day == 2 || Day == 5 || Day == 12 || Day == 17 || Day == 59 || Day == 60)
            {
                Dylan_Day();
            }
            else
            {
                Dylan_Reliability_Scene();
            }
        }//AM 코드 수정해야하는 상태
        else if (SceneName.Equals("AM"))
        {
            reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability");
            Frances_Reliability_Scene();
        }
        else if (SceneName.Equals("Daily_schedule"))
        {
            if (Day == 1 || Day == 8 || Day == 17 || Day == 18 || Day == 36 || Day == 51
                || Day == 52 || Day == 53 || Day == 54 || Day == 57 || Day == 58)//일과 중 안넣은 상태
            {
                Dailyschedule_Day();
            }
            else
            {
                _randomNPC.SetNPCCount();
            }
        }
    }

    public void fadein()
    {
        _fadeout.FadeIn();
    }
    // 헤더(딸) Flowchart 호출
    public void Heather_Reliability_Scene()
    {
        Debug.Log(reliability);
        if (reliability >= 60 && reliability <= 100)
        {
            Debug.Log("실행");
            int rand = Random.Range(1, 6);
            GameObject.Find("Flowchart_").transform.Find("Morethan60").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Morethan60", SceneName);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetConversationFlag(rand);

        }
        else if (reliability >= 0 && reliability < 60)
        {
            int rand = Random.Range(6, 10);
            GameObject.Find("Flowchart_").transform.Find("Lessthan60").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Lessthan60", SceneName);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetConversationFlag(rand);
        }
    }

    public void Heather_Day1()
    {
        GameObject.Find("Flowchart_").transform.Find("Day1").gameObject.SetActive(true);
    }
    public void Heather_Day4()
    {
        GameObject.Find("Flowchart_").transform.Find("Day4").gameObject.SetActive(true);
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
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetConversationFlag(rand);
        }
        else if (Revolutionary_route == true)
        {
            int rand = Random.Range(8, 10);// 대사 추가시 수정 요구
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Revolutionary_route", SceneName);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetConversationFlag(rand);
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
    public void Hilda_Day3()
    {
        GameObject.Find("Flowchart_").transform.Find("Day3").gameObject.SetActive(true);
    }
    //Flowchart 호출
    public void Dylan_Reliability_Scene()
    {
        //힐다, 딜런은 호감도에 따른 대화 변경이 아닌 혁명루트에 따른 대화 변화
        if (Revolutionary_route == false)
        {
            int rand = Random.Range(1, 6);
            GameObject.Find("Flowchart_").transform.Find("Normal").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Normal", SceneName);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetConversationFlag(rand);
        }
        else if (Revolutionary_route == true)
        {
            int rand = Random.Range(6, 10);
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Revolutionary_route", SceneName);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetConversationFlag(rand);
        }
        Debug.Log("딜런 대화 시작");
    }
    public void Dylan_Day()
    {
        GameObject.Find("Flowchart_").transform.Find("Day"+Day).gameObject.SetActive(true);
    }
    public void Dailyschedule_Day()
    {
        GameObject.Find("FC").transform.Find("Day" + Day).gameObject.SetActive(true);
    }
    // 프랜시스 Flowchart 호출
    public void Frances_Reliability_Scene()
    {
        // 헤더, 프랜시스는 신뢰도에 따라 대화 변화가 이뤄짐
        //if (reliability >= 80 && reliability <= 100)
        if (reliability >= 0&& reliability<80)
        {
            int rand = Random.Range(1, 7);
            GameObject.Find("Flowchart_").transform.Find("Morethan80").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Morethan80", SceneName);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetConversationFlag(rand);
        }
        else if (reliability >= 80 && reliability <= 100)
        {
            int rand = Random.Range(7, 14);// 혁명 루트 추가시 수정 요구
            GameObject.Find("Flowchart_").transform.Find("Lessthan80").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Lessthan80", SceneName);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetConversationFlag(rand);
        }
    }

}
