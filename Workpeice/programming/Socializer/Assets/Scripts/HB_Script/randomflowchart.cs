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

    public int Day;

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

            if (Day == 1 || Day == 4 || Day == 8 || Day == 15 || Day == 22 || Day == 29 || Day == 31
                || Day == 32 || Day == 33 || Day == 36 || Day == 50 || Day == 51 || Day == 52 || Day == 53 || Day == 54 || Day == 58 || Day == 59)
            {
                Debug.Log("집 도착");
                Heather_Day();
            }
            else
            {
                Heather_Reliability_Scene();
            }
        }
        else if (SceneName.Equals("Lobby"))
        {
            reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability");

            if (Day == 3 || Day == 39 || Day == 50 || Day == 52 || Day == 54 || Day == 57 || Day == 58 || Day == 59 || Day == 60)
            {
                Hilda_Day();
            }
            else if (Day == 38)
            {

            }
            else
            {
                Hilda_Reliability_Scene();
            }
        }
        else if (SceneName.Equals("Office"))
        {
            reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability");
            
            if (Day == 1 || Day == 2 || Day == 5 || Day == 12 || Day == 17 || Day == 18 || Day == 39 || Day == 59 || Day == 60)
            {
                Dylan_Day();
            }
            else
            {
                Dylan_Reliability_Scene();
            }
        }
        else if (SceneName.Equals("AM"))
        {
            reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability");

            if (Day == 18 || Day == 19 || Day == 24 || Day == 36 || Day == 39 || Day == 45)
            {
                Frances_Day();
            }
            else if (Day >= 47)
            {
                if(Day == 58 || Day == 59 || Day == 60)
                {
                    Frances_Day();
                }
            }
            else
            {
                Frances_Reliability_Scene();
            }
        }
        else if (SceneName.Equals("Daily_schedule"))
        {
            if (Day == 1 || Day == 8 || Day == 17 || Day == 18 || Day == 36 || Day == 38 || Day == 39 || Day == 51
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

    public void Heather_Day()
    {
        if (Revolutionary_route == true && Day == 22 && PlayerPrefs.GetInt("Day" + Day + "_Office_After_RevolutionaryRoute") == 0)
        {
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Day22").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Day" + Day + "_House_Revolutionary_route", 1);
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Day22").GetComponent<Flowchart>().SetFloatVariable("Heather_reliability",
                GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability"));
        }
        else if (Revolutionary_route == true && Day == 29 && PlayerPrefs.GetInt("Day" + Day + "_Office_After_RevolutionaryRoute") == 0)
        {
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Day29").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Day" + Day + "_House_Revolutionary_route", 1);
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Day29").GetComponent<Flowchart>().SetFloatVariable("Heather_reliability",
                GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability"));
        }
        else if (Revolutionary_route == true && Day == 32 && PlayerPrefs.GetInt("Day" + Day + "_Office_After_RevolutionaryRoute") == 0)
        {
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Day32").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Day" + Day + "_House_Revolutionary_route", 1);
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Day32").GetComponent<Flowchart>().SetFloatVariable("Heather_reliability",
                GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability"));
        }
        else if (Revolutionary_route == true && Day == 33 && PlayerPrefs.GetInt("Day" + Day + "_Office_After_RevolutionaryRoute") == 0)
        {
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Day33").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Day" + Day + "_House_Revolutionary_route", 1);
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Day33").GetComponent<Flowchart>().SetFloatVariable("Heather_reliability",
                GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability"));
        }
        else if (Revolutionary_route == true && Day == 36 && PlayerPrefs.GetInt("Day" + Day + "_Office_After_RevolutionaryRoute") == 0)
        {
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Day36").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Day" + Day + "_House_Revolutionary_route", 1);
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Day36").GetComponent<Flowchart>().SetFloatVariable("Heather_reliability",
                GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability"));
        }
        else
        {
            if (PlayerPrefs.GetInt("Day" + Day + "_House") == 0)
            {
                if (PlayerPrefs.GetInt("Ending1") == 1 && PlayerPrefs.GetInt("Ending2") == 0)
                {
                    GameObject.Find("Flowchart_").transform.Find("Ending1").transform.Find("Day" + Day).gameObject.SetActive(true);
                    PlayerPrefs.SetInt("Day" + Day + "_House", 1);
                    GameObject.Find("Flowchart_").transform.Find("Ending1").transform.Find("Day" + Day).GetComponent<Flowchart>().SetFloatVariable("Heather_reliability",
                        GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability"));
                }
                else if (PlayerPrefs.GetInt("Ending1") == 0 && PlayerPrefs.GetInt("Ending2") == 1)
                {
                    GameObject.Find("Flowchart_").transform.Find("Ending2").transform.Find("Day" + Day).gameObject.SetActive(true);
                    PlayerPrefs.SetInt("Day" + Day + "_House", 1);
                    GameObject.Find("Flowchart_").transform.Find("Ending2").transform.Find("Day" + Day).GetComponent<Flowchart>().SetFloatVariable("Heather_reliability",
                        GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability"));
                }
                else {
                    Debug.Log(Day + "일차 이벤트");
                    GameObject.Find("Flowchart_").transform.Find("Day" + Day).gameObject.SetActive(true);
                    PlayerPrefs.SetInt("Day" + Day + "_House", 1);
                    GameObject.Find("Flowchart_").transform.Find("Day" + Day).GetComponent<Flowchart>().SetFloatVariable("Heather_reliability",
                        GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability"));
                }
            }
            else
                Heather_Reliability_Scene();
        }
    }
    public void Dylan_Day()
    {
        
        if (Revolutionary_route == true && Day == 39 && PlayerPrefs.GetInt("Day38_Office_After_RevolutionaryRoute") == 0)
        {
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Day39").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Day38_Office_After_RevolutionaryRoute", 1);
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Day39").GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability",
                GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));
        }
        else if (Revolutionary_route == true && Day == 59 && PlayerPrefs.GetInt("Day38_Office_After_RevolutionaryRoute") == 0 
            && PlayerPrefs.GetInt("Ending1") == 1 && PlayerPrefs.GetInt("Ending2") == 0)
        {
            GameObject.Find("Flowchart_").transform.Find("Ending1").transform.Find("Day59").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Day59_Office_After_RevolutionaryRoute", 1);
            GameObject.Find("Flowchart_").transform.Find("Ending1").transform.Find("Day59").GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability",
                GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));
        }
        else if (Revolutionary_route == true && Day == 60 && PlayerPrefs.GetInt("Day38_Office_After_RevolutionaryRoute") == 0 
            && PlayerPrefs.GetInt("Ending1") == 1 && PlayerPrefs.GetInt("Ending2") == 0)
        {
            GameObject.Find("Flowchart_").transform.Find("Ending1").transform.Find("Day60").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Day60_Office_After_RevolutionaryRoute", 1);
            GameObject.Find("Flowchart_").transform.Find("Ending1").transform.Find("Day60").GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability",
                GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));
        }
        else
        {
            if (PlayerPrefs.GetInt("Day"+Day+ "_Office_After") == 0)
            {
                GameObject.Find("Flowchart_").transform.Find("Day" + Day).gameObject.SetActive(true);
                PlayerPrefs.SetInt("Day"+Day+ "_Office_After", 1);
                GameObject.Find("Flowchart_").transform.Find("Day" + Day).GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability",
                    GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));
            }
            else
                Dylan_Reliability_Scene();
        }
    }
    public void Hilda_Day()
    {

        if (Revolutionary_route == true && Day == 38 && PlayerPrefs.GetInt("Day38_Lobby_RevolutionaryRoute") == 0)
        {
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Day38").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Day38_Lobby_RevolutionaryRoute", 1);
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Day38").GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability",
                GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));
        }
        else if (Revolutionary_route == true && Day == 39 && PlayerPrefs.GetInt("Day39_Lobby_RevolutionaryRoute") == 0)
        {
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Day39").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Day39_Lobby_RevolutionaryRoute", 1);
            GameObject.Find("Flowchart_").transform.Find("Revolutionary_route").transform.Find("Day39").GetComponent<Flowchart>().SetFloatVariable("Hilda_reliability",
                GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability"));
        }
        else if (Day == 50)
        {
            float H_Reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_Reliability");
            float F_Reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_Reliability");
            if (H_Reliability >= 80 && F_Reliability >= 80 && PlayerPrefs.GetInt("Day50_Lobby") == 0)
            {
                GameObject.Find("Flowchart_").transform.Find("Day" + Day).gameObject.SetActive(true);
                GameObject.Find("Flowchart_").transform.Find("Day" + Day).GetComponent<Flowchart>().SetFloatVariable("Hilda_Reliability",
                    GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_Reliability"));
                PlayerPrefs.SetInt("Day50_Lobby", 1);
            }
            else
                Hilda_Reliability_Scene();
        }
        else
        {
            if (PlayerPrefs.GetInt("Day" + Day + "_Lobby") == 0)
            {
                if(PlayerPrefs.GetInt("Day" + Day + "_Lobby") == 0 && PlayerPrefs.GetInt("Ending1") == 1 && PlayerPrefs.GetInt("Ending2") == 0)
                {
                    GameObject.Find("Flowchart_").transform.Find("Ending1").transform.Find("Day" + Day).gameObject.SetActive(true);
                    PlayerPrefs.SetInt("Day" + Day + "_Lobby", 1);
                    GameObject.Find("Flowchart_").transform.Find("Ending1").transform.Find("Day" + Day).GetComponent<Flowchart>().SetFloatVariable("Hilda_Reliability",
                        GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_Reliability"));
                }
                else if (PlayerPrefs.GetInt("Day" + Day + "_Lobby") == 0 && PlayerPrefs.GetInt("Ending1") == 0 && PlayerPrefs.GetInt("Ending2") == 1)
                {
                    GameObject.Find("Flowchart_").transform.Find("Ending2").transform.Find("Day" + Day).gameObject.SetActive(true);
                    PlayerPrefs.SetInt("Day" + Day + "_Lobby", 1);
                    GameObject.Find("Flowchart_").transform.Find("Ending2").transform.Find("Day" + Day).GetComponent<Flowchart>().SetFloatVariable("Hilda_Reliability",
                        GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_Reliability"));
                }
                else
                {
                    GameObject.Find("Flowchart_").transform.Find("Day" + Day).gameObject.SetActive(true);
                    PlayerPrefs.SetInt("Day" + Day + "_Lobby", 1);
                    GameObject.Find("Flowchart_").transform.Find("Day" + Day).GetComponent<Flowchart>().SetFloatVariable("Hilda_Reliability",
                        GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_Reliability"));
                }
            }
            else
                Hilda_Reliability_Scene();
        }
    }
    public void Frances_Day()
    {
        if (PlayerPrefs.GetInt("Day"+Day+"_AM") == 0 && PlayerPrefs.GetInt("Ending1") == 0 && PlayerPrefs.GetInt("Ending2") == 0)
        {
            GameObject.Find("Flowchart_").transform.Find("Day" + Day).gameObject.SetActive(true);
            PlayerPrefs.SetInt("Day" + Day + "_AM", 1);
            GameObject.Find("Flowchart_").transform.Find("Day" + Day).GetComponent<Flowchart>().SetFloatVariable("Frances_Reliability",
                GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_Reliability"));
        }
        else if (PlayerPrefs.GetInt("Day" + Day + "_AM") == 0 && PlayerPrefs.GetInt("Ending1") == 1 && PlayerPrefs.GetInt("Ending2") == 0)
        {
            GameObject.Find("Flowchart_").transform.Find("Ending1").transform.Find("Day" + Day).gameObject.SetActive(true);
            PlayerPrefs.SetInt("Day" + Day + "_AM", 1);
            GameObject.Find("Flowchart_").transform.Find("Ending1").transform.Find("Day" + Day).GetComponent<Flowchart>().SetFloatVariable("Frances_Reliability",
                GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_Reliability"));
        }
        else if (PlayerPrefs.GetInt("Day" + Day + "_AM") == 0 && PlayerPrefs.GetInt("Ending1") == 0 && PlayerPrefs.GetInt("Ending2") == 1)
        {
            GameObject.Find("Flowchart_").transform.Find("Ending2").transform.Find("Day" + Day).gameObject.SetActive(true);
            PlayerPrefs.SetInt("Day" + Day + "_AM", 1);
            GameObject.Find("Flowchart_").transform.Find("Ending2").transform.Find("Day" + Day).GetComponent<Flowchart>().SetFloatVariable("Frances_Reliability",
                GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_Reliability"));
        }
        else
        {
            Frances_Reliability_Scene();
        }
    }
    public void Dailyschedule_Day()
    {
        if (Revolutionary_route == true && Day == 36 && PlayerPrefs.GetInt("Day" + Day + "_Office_Before_RevolutionaryRoute") == 0)
        {
            GameObject.Find("FC").transform.Find("Revolutionary_route").transform.Find("Day36").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Day36_Office_Before_RevolutionaryRoute", 1);
            GameObject.Find("FC").transform.Find("Revolutionary_route").transform.Find("Day36").GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability",
                GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));
        }
        else if (Revolutionary_route == true && Day == 38 && PlayerPrefs.GetInt("Day" + Day + "_Office_Before_RevolutionaryRoute") == 0)
        {
            GameObject.Find("FC").transform.Find("Revolutionary_route").transform.Find("Day38").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Day38_Office_Before_RevolutionaryRoute", 1);
            GameObject.Find("FC").transform.Find("Revolutionary_route").transform.Find("Day38").GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability",
                GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));
        }
        else if (Revolutionary_route == true && Day == 39 && PlayerPrefs.GetInt("Day" + Day + "_Office_Before_RevolutionaryRoute") == 0)
        {
            GameObject.Find("FC").transform.Find("Revolutionary_route").transform.Find("Day39").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Day39_Office_Before_RevolutionaryRoute", 1);
            GameObject.Find("FC").transform.Find("Revolutionary_route").transform.Find("Day39").GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability",
                GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));
        }
        else
        {
            if (PlayerPrefs.GetInt("Day" + Day + "_Office_Before") == 0)
            {
                if (PlayerPrefs.GetInt("Ending1") == 1 && PlayerPrefs.GetInt("Ending2") == 0)
                {
                    GameObject.Find("FC").transform.Find("Ending1").transform.Find("Day" + Day).gameObject.SetActive(true);
                    PlayerPrefs.SetInt("Day" + Day + "_Office_Before", 1);
                    GameObject.Find("FC").transform.Find("Ending1").transform.Find("Day" + Day).GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability",
                        GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));
                }
                else if(PlayerPrefs.GetInt("Ending1") == 0 && PlayerPrefs.GetInt("Ending2") == 1)
                {
                    GameObject.Find("FC").transform.Find("Ending2").transform.Find("Day" + Day).gameObject.SetActive(true);
                    PlayerPrefs.SetInt("Day" + Day + "_Office_Before", 1);
                    GameObject.Find("FC").transform.Find("Ending2").transform.Find("Day" + Day).GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability",
                        GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));
                }
                else
                {
                    GameObject.Find("FC").transform.Find("Day" + Day).gameObject.SetActive(true);
                    PlayerPrefs.SetInt("Day" + Day + "_Office_Before", 1);
                    GameObject.Find("FC").transform.Find("Day" + Day).GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability",
                        GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));
                }
            }
            else
                _randomNPC.SetNPCCount();

        }
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
    // 힐다 Flowchart 호출
    public void Hilda_Reliability_Scene()
    {
        //힐다, 딜런은 호감도에 따른 대화 변경이 아닌 혁명루트에 따른 대화 변화
        
        int rand = Random.Range(1, 8);
        GameObject.Find("Flowchart_").transform.Find("Normal").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
        GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Normal", SceneName);
        GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetConversationFlag(rand);
        
    }

    //Flowchart 호출
    public void Dylan_Reliability_Scene()
    {
        //힐다, 딜런은 호감도에 따른 대화 변경이 아닌 혁명루트에 따른 대화 변화
        int rand = Random.Range(1, 6);
        GameObject.Find("Flowchart_").transform.Find("Normal").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
        GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Normal", SceneName);
        GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetConversationFlag(rand);
        Debug.Log("딜런 대화 시작");
    }
    
    // 프랜시스 Flowchart 호출
    public void Frances_Reliability_Scene()
    {
        // 헤더, 프랜시스는 신뢰도에 따라 대화 변화가 이뤄짐
        //if (reliability >= 80 && reliability <= 100)
        if (reliability >= 80 && reliability <= 100)
        {
            int rand = Random.Range(1, 7);
            GameObject.Find("Flowchart_").transform.Find("Morethan80").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Morethan80", SceneName);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetConversationFlag(rand);
        }
        else if (reliability >= 0 && reliability < 80)
        {
            int rand = Random.Range(7, 14);// 혁명 루트 추가시 수정 요구
            GameObject.Find("Flowchart_").transform.Find("Lessthan80").transform.Find("Flowchart" + rand).gameObject.SetActive(true);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetFlag(rand, "Lessthan80", SceneName);
            GameObject.Find("Flowchart_").GetComponent<Conversation_flag>().GetConversationFlag(rand);
        }
    }

}
