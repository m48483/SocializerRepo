﻿using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Conversation_flag : MonoBehaviour
{
    bool Heather_conversation = false;
    bool Frances_conversation = false;
    bool Hilda_conversation = false;
    bool Dylan_conversation = false;
    string SceneName;// 씬이름 구별

    // 하루일과를 진행하면서 NPC와 대화를 진행하였는지 체크
    public void Flag_Initialization()
    {
        Debug.Log("NPC 대화 초기화");
        // 하루가 지나면 대화 플래그 false로 초기화, 일과 Scene을 시작할 때 메소드 호출
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Heather_conversation", false);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Frances_conversation", false);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Hilda_conversation", false);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Dylan_conversation", false);

        PlayerPrefs.SetInt("Heather_conversation", 0);
        PlayerPrefs.SetInt("Frances_conversation", 0);
        PlayerPrefs.SetInt("Hilda_conversation", 0);
        PlayerPrefs.SetInt("Dylan_conversation", 0);
    }

    // 대화를 마치면 대화 플래그 값 true로 변경
    public void FlagtoTrue()
    {
        SceneName = SceneManager.GetActiveScene().name;

        if (SceneName.Equals("House"))
        {
            Heather_conversation = true;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Heather_conversation", Heather_conversation);
            PlayerPrefs.SetInt("Heather_conversation", 1);
        }
        else if (SceneName.Equals("Lobby"))
        {
            Hilda_conversation = true;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Hilda_conversation", Hilda_conversation);
            PlayerPrefs.SetInt("Hilda_conversation", 1);
        }
        else if (SceneName.Equals("Office"))
        {
            Hilda_conversation = true;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Dylan_conversation", Dylan_conversation);
            PlayerPrefs.SetInt("Dylan_conversation", 1);
        }
        else if (SceneName.Equals("AM"))
        {
            Heather_conversation = true;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Frances_conversation", Frances_conversation);
            PlayerPrefs.SetInt("Frances_conversation", 1);
        }
    }

    public void FlagtoTrue_Office_Before_RevolutionaryRoute()
    {
        PlayerPrefs.SetInt("Day"+PlayerPrefs.GetInt("Day")+ "_Office_Before", 1);
    }
    public void FlagtoTrue_Office_Before()
    {
        PlayerPrefs.SetInt("Day" + PlayerPrefs.GetInt("Day") + "_Office_Before_RevolutionaryRoute", 1);
    }
    public void FlagtoTrue_Office_Middle()
    {
        PlayerPrefs.SetInt("Day" + PlayerPrefs.GetInt("Day") + "_Office_Middle", 1);
    }
    public void FlagtoTrue_Office_Middle_RevolutionaryRoute()
    {
        PlayerPrefs.SetInt("Day" + PlayerPrefs.GetInt("Day") + "_Office_Middle_RevolutionaryRoute", 1);
    }
    public void FlagtoTrue_Office_After()
    {
        PlayerPrefs.SetInt("Day" + PlayerPrefs.GetInt("Day") + "_Office_After", 1);
    }
    public void FlagtoTrue_Office_Afte_RevolutionaryRouter()
    {
        PlayerPrefs.SetInt("Day" + PlayerPrefs.GetInt("Day") + "_Office_After_RevolutionaryRoute", 1);
    }
    public void FlagtoTrue_Lobby()
    {
        PlayerPrefs.SetInt("Day" + PlayerPrefs.GetInt("Day") + "_Lobby", 1);
    }
    public void FlagtoTrue_Lobby_RevolutionaryRoute()
    {
        PlayerPrefs.SetInt("Day" + PlayerPrefs.GetInt("Day") + "_Lobby_RevolutionaryRoute", 1);
    }
    public void FlagtoTrue_Office()
    {
        PlayerPrefs.SetInt("Day" + PlayerPrefs.GetInt("Day") + "_Office", 1);
    }
    public void FlagtoTrue_Office_RevolutionaryRoute()
    {
        PlayerPrefs.SetInt("Day" + PlayerPrefs.GetInt("Day") + "_Office_RevolutionaryRoute", 1);
    }
    public void FlagtoTrue_AM()
    {
        PlayerPrefs.SetInt("Day" + PlayerPrefs.GetInt("Day") + "_AM", 1);
    }
    public void FlagtoTrue_AM_RevolutionaryRoute()
    {
        PlayerPrefs.SetInt("Day" + PlayerPrefs.GetInt("Day") + "_AM_RevolutionaryRoute", 1);
    }

    /*
    //flowchart 버그 미발견으로 임시적으로 오버로딩
    public void GetFlag()
    {
        SceneName = SceneManager.GetActiveScene().name;
        if (SceneName.Equals("House"))
        {
            
        }
        else if (SceneName.Equals("Lobby"))
        {
            Hilda_conversation = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Hilda_conversation");
            GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Hilda_conversation", Hilda_conversation);
        }
        else if (SceneName.Equals("Office"))
        {
            Hilda_conversation = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Dylan_conversation");
            GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Dylan_conversation", Dylan_conversation);
        }
        else if (SceneName.Equals("AM"))
        {
            Frances_conversation = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Frances_conversation");
            GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Frances_conversation", Frances_conversation);
        }
    }
    */
    //대화를 진행했는가 확인하는 플래그

    public void GetConversationFlag(int i)
    {
        SceneName = SceneManager.GetActiveScene().name;

        if (SceneName.Equals("House"))
        {
            float H_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability");
            if (H_reliability > 60)
            {
                GameObject.Find("Flowchart_").transform.Find("Morethan60").transform.Find("Flowchart" + i).GetComponent<Flowchart>()
                    .SetBooleanVariable("Heather_conversation", GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Heather_conversation"));
            }
            else if (H_reliability <= 60)
            {
                GameObject.Find("Flowchart_").transform.Find("Lessthan60").transform.Find("Flowchart" + i).GetComponent<Flowchart>()
                    .SetBooleanVariable("Heather_conversation", GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Heather_conversation"));
            }

        }
        else if (SceneName.Equals("Lobby"))
        {
            GameObject.Find("Flowchart_").transform.Find("Normal").transform.Find("Flowchart" + i).GetComponent<Flowchart>()
                    .SetBooleanVariable("Hilda_conversation", GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Hilda_conversation"));
        }
        else if (SceneName.Equals("Office"))
        {
            GameObject.Find("Flowchart_").transform.Find("Normal").transform.Find("Flowchart" + i).GetComponent<Flowchart>()
                    .SetBooleanVariable("Dylan_conversation", GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Dylan_conversation"));
        }
        else if (SceneName.Equals("AM"))
        {
            GameObject.Find("Flowchart_").transform.Find("Normal").transform.Find("Flowchart" + i).GetComponent<Flowchart>()
                     .SetBooleanVariable("Frances_conversation", GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Frances_conversation"));
        }
    }

    public void GetFlag(int rand, string str, string place)
    {
        //str : 호감도 또는 혁명루트
        SceneName = SceneManager.GetActiveScene().name;
        Debug.Log("Conversation_flag 스크립트, 장소 : " + SceneName);
        if (place.Equals("House"))
        {
            //추후 호감도/혁명루트에 따라 코드 수정해야함
            Heather_conversation = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Heather_conversation");
            GameObject.Find("Flowchart_").transform.Find(str).transform.Find("Flowchart" + rand).GetComponent<Flowchart>().SetBooleanVariable("Heather_conversation", Heather_conversation);
            Debug.Log("flag값 얻어옴");
        }
        else if (place.Equals("Lobby"))
        {
            Hilda_conversation = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Hilda_conversation");
            GameObject.Find("Flowchart_").transform.Find(str).transform.Find("Flowchart" + rand).GetComponent<Flowchart>().SetBooleanVariable("Hilda_conversation", Hilda_conversation);
        }
        else if (place.Equals("Office"))
        {
            Dylan_conversation = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Dylan_conversation");
            GameObject.Find("Flowchart_").transform.Find(str).transform.Find("Flowchart" + rand).GetComponent<Flowchart>().SetBooleanVariable("Dylan_conversation", Dylan_conversation);
        }
        else if (place.Equals("AM"))
        {
            Frances_conversation = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Frances_conversation");
            GameObject.Find("Flowchart_").transform.Find(str).transform.Find("Flowchart" + rand).GetComponent<Flowchart>().SetBooleanVariable("Frances_conversation", Frances_conversation);
        }
    }


}

/*
variables 변수들 초기화
씬 시작시 불러옴
대화 후 저장(variables에)
이동
다시 이동
씬 시작시 불러옴
체크
*/