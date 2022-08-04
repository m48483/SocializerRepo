using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVariablesManager : MonoBehaviour
{
    bool isGameOver;
    bool citizen;
    bool Frances_conversation;
    bool Hilda_conversation;
    // name에서 플레이어프리팹 null Set
    void Start()
    {
        Debug.Log("PlayerPrefs에 setting 중...");
        PlayerPrefs.SetString("PlayerName", "아스트리드");
        // 0 false 1 true
        PlayerPrefs.SetInt("Daily_schedule", 0);
        PlayerPrefs.SetInt("Heather_conversation", 0);
        PlayerPrefs.SetInt("Hilda_conversation", 0);
        PlayerPrefs.SetInt("Dylan_conversation", 0);
        PlayerPrefs.SetInt("Frances_conversation", 0);

        PlayerPrefs.SetFloat("Heather_reliability", 50);
        PlayerPrefs.SetFloat("Hilda_reliability", 80);
        PlayerPrefs.SetFloat("Dylan_reliability", 40);
        PlayerPrefs.SetFloat("Frances_reliability", 10);
        PlayerPrefs.SetInt("Day", 1);

        PlayerPrefs.SetInt("Gameover", 0);
        PlayerPrefs.SetInt("Revolutionary_route", 0);

        PlayerPrefs.SetInt("ReactionaryNPC", 0);
        PlayerPrefs.SetInt("Citizen", 0);
        PlayerPrefs.SetInt("Pass", 0);
        PlayerPrefs.SetInt("Arrest", 0);
        PlayerPrefs.SetInt("Kill", 0);

        PlayerPrefs.SetInt("RevolutionaryNPC", 0);
        PlayerPrefs.SetInt("RevolutionaryPass", 0);
        PlayerPrefs.SetInt("Tier1NPC", 0);


        // 특정 날짜에 장소에서 대화했는가를 저장하는 변수들
        // 변수명 작성 기준 : Day_Place_Before/Middle/After_ RevolutionaryRoute

        //사무실_Before
        PlayerPrefs.SetInt("Day1_Office_Before", 0);
        PlayerPrefs.SetInt("Day8_Office_Before", 0);
        PlayerPrefs.SetInt("Day12_Office_Before", 0);
        PlayerPrefs.SetInt("Day17_Office_Before", 0);
        PlayerPrefs.SetInt("Day36_Office_Before", 0);
        PlayerPrefs.SetInt("Day36_Office_Before_RevolutionaryRoute", 0);
        PlayerPrefs.SetInt("Day38_Office_Before_RevolutionaryRoute", 0);
        PlayerPrefs.SetInt("Day39_Office_Before", 0);
        PlayerPrefs.SetInt("Day39_Office_Before_RevolutionaryRoute", 0);
        PlayerPrefs.SetInt("Day51_Office_Before", 0);
        PlayerPrefs.SetInt("Day53_Office_Before", 0);
        PlayerPrefs.SetInt("Day54_Office_Before", 0);
        PlayerPrefs.SetInt("Day57_Office_Before", 0);

        //사무실_Middle
        PlayerPrefs.SetInt("Day19_Office_After", 0);
        PlayerPrefs.SetInt("Day19_Office_After_RevolutionaryRoute", 0);
        PlayerPrefs.SetInt("Day25_Office_After", 0);
        PlayerPrefs.SetInt("Day25_Office_After_RevolutionaryRoute", 0);

        //사무실_After
        PlayerPrefs.SetInt("Day1_Office_After", 0);
        PlayerPrefs.SetInt("Day2_Office_After", 0);
        PlayerPrefs.SetInt("Day5_Office_After", 0);
        PlayerPrefs.SetInt("Day12_Office_After", 0);
        PlayerPrefs.SetInt("Day17_Office_After_RevolutionaryRoute", 0);
        PlayerPrefs.SetInt("Day59_Office_After_RevolutionaryRoute", 0);

        //로비
        PlayerPrefs.SetInt("Day3_Lobby", 0);
        PlayerPrefs.SetInt("Day17_Lobby", 0);
        PlayerPrefs.SetInt("Day38_Lobby", 0);
        PlayerPrefs.SetInt("Day38_Lobby_RevolutionaryRoute", 0);
        PlayerPrefs.SetInt("Day39_Lobby_RevolutionaryRoute", 0);
        PlayerPrefs.SetInt("Day50_Lobby", 0);
        PlayerPrefs.SetInt("Day52_Lobby", 0);
        PlayerPrefs.SetInt("Day54_Lobby", 0);
        PlayerPrefs.SetInt("Day57_Lobby", 0);
        PlayerPrefs.SetInt("Day58_Lobby", 0);
        PlayerPrefs.SetInt("Day59_Lobby", 0);
        PlayerPrefs.SetInt("Day60_Lobby", 0);

        //집
        PlayerPrefs.SetInt("Day1_Lobby", 0);
        PlayerPrefs.SetInt("Day4_Lobby", 0);
        PlayerPrefs.SetInt("Day8_Lobby", 0);
        PlayerPrefs.SetInt("Day15_Lobby", 0);
        PlayerPrefs.SetInt("Day22_Lobby", 0);
        PlayerPrefs.SetInt("Day22_Lobby_RevolutionaryRoute", 0);
        PlayerPrefs.SetInt("Day29_Lobby", 0);
        PlayerPrefs.SetInt("Day29_Lobby_RevolutionaryRoute", 0);
        PlayerPrefs.SetInt("Day31_Lobby", 0);
        PlayerPrefs.SetInt("Day32_Lobby_RevolutionaryRoute", 0);
        PlayerPrefs.SetInt("Day33_Lobby", 0);
        PlayerPrefs.SetInt("Day33_Lobby_RevolutionaryRoute", 0);
        PlayerPrefs.SetInt("Day36_Lobby", 0);
        PlayerPrefs.SetInt("Day36_Lobby_RevolutionaryRoute", 0);
        PlayerPrefs.SetInt("Day51_Lobby", 0);
        PlayerPrefs.SetInt("Day54_Lobby", 0);

        //AM
        PlayerPrefs.SetInt("Day19_Lobby", 0);
        PlayerPrefs.SetInt("Day24_Lobby", 0);
        PlayerPrefs.SetInt("Day39_Lobby_RevolutionaryRoute", 0);
        PlayerPrefs.SetInt("Day45_Lobby", 0);
        PlayerPrefs.SetInt("Day47_Lobby", 0);
        PlayerPrefs.SetInt("Day50_Lobby", 0);
        PlayerPrefs.SetInt("Day59_Lobby", 0);
        PlayerPrefs.SetInt("Day60_Lobby", 0);


        //int day = PlayerPrefs.GetInt("Day");
        //string name = PlayerPrefs.GetString("Name");
        //float Hilda_reliability = PlayerPrefs.GetFloat("Hilda_reliability");
        //float Heather_reliability = PlayerPrefs.GetFloat("Heather_reliability");
        //float Frances_reliability = PlayerPrefs.GetFloat("Frances_reliability");
        //float Dylan_reliability = PlayerPrefs.GetFloat("Dylan_reliability");
        //int isGameOverInt = PlayerPrefs.GetInt("Gameover");
        //int citizenInt = PlayerPrefs.GetInt("Citizen");
        //int Frances_conversation_Int = PlayerPrefs.GetInt("Frances_conversation");
        //int Hilda_conversation_Int = PlayerPrefs.GetInt("Hilda_conversation");

        //// 임시

        //if (isGameOverInt == 0) { isGameOver = true; }
        //else if (isGameOverInt == 1) { isGameOver = false; }

        //if (citizenInt == 0) { citizen = true; }
        //else if (citizenInt == 1) { citizen = false; }

        //if (Frances_conversation_Int == 0) { Frances_conversation = true; }
        //else if (Frances_conversation_Int == 1) { Frances_conversation = false; }

        //if (Hilda_conversation_Int == 0) { Hilda_conversation = true; }
        //else if (Frances_conversation_Int == 1) { Hilda_conversation = false; }

        //GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Day", day);
        //GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Hilda_reliability", Hilda_reliability);
        //GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Heather_reliability", Heather_reliability);
        //GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Frances_reliability", Frances_reliability);
        //GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability", Dylan_reliability);
        //GameObject.Find("Variables").GetComponent<Flowchart>().SetStringVariable("PlayerName", name);
        ////GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Gameover", isGameOver);
        //GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Citizen", citizen);
        //GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Frances_conversation", Frances_conversation);
        //GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Hilda_conversation", Hilda_conversation);

    }
}
