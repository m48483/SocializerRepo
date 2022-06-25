using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
using UnityEngine.SceneManagement;

public class SaveManager : MonoBehaviour
{
    public GameObject continueBtn;
    public GameObject btnImage;

    //bool isGameOver;   //게임 오버
    bool Daily_schedule;   //일과진행
    bool citizen;   //false시 사망
    bool Frances_conversation;   //AM 접촉시 true
    bool Hilda_conversation;   //정보부 NPC에게 이를 알림

    int isGameOverInt;
    int citizenInt;
    int Frances_conversation_Int;
    int Hilda_conversation_Int;   

    public void Start()
    {
        if(SceneManager.GetActiveScene().name == "Title")
        {
            if (!PlayerPrefs.HasKey("Day"))
            {
                continueBtn.SetActive(false);
                btnImage.SetActive(true);
                Debug.Log("저장된 데이터가 없습니다.");
                return;
            }
            else
            {
                continueBtn.SetActive(true);
                btnImage.SetActive(false);
                //SpriteRenderer spr = GetComponent<SpriteRenderer>();

                //Color color = spr.color;
                //color.a = 0.5f;
                //spr.color = color;
                //Color color = btnImage.GetComponent<Image>().color;
                //color.a = 0.5f;
                //btnImage.GetComponent<Image>().color = color;
            }
        }
    }

    public void GameSave()
    {
        Daily_schedule = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Daily_schedule");

        Debug.Log("데이터를 저장합니다.");
        //isGameOver = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Gameover");
        citizen = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Citizen");
        Frances_conversation = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Frances_conversation");
        Hilda_conversation = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Hilda_conversation");

        // 0 == true, 1 == false

        //if (isGameOver) { isGameOverInt = 0; }
        //else { isGameOverInt = 1; }

        if (citizen) { citizenInt = 0; }
        else { citizenInt = 1; }

        if (Frances_conversation) { Frances_conversation_Int = 0; }
        else { Frances_conversation_Int = 1; }

        if (Hilda_conversation) { Hilda_conversation_Int = 0; }
        else { Hilda_conversation_Int = 1; }

        PlayerPrefs.SetInt("Day", GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Day"));
        PlayerPrefs.SetFloat("Hilda_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability"));
        PlayerPrefs.SetFloat("Heather_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability"));
        PlayerPrefs.SetFloat("Frances_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability"));
        PlayerPrefs.SetFloat("Dylan_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));
        PlayerPrefs.SetInt("Gameover", isGameOverInt);
        PlayerPrefs.SetInt("Citizen", citizenInt);
        PlayerPrefs.SetInt("Frances_conversation", Frances_conversation_Int);
        PlayerPrefs.SetInt("Hilda_conversation", Hilda_conversation_Int);

        PlayerPrefs.Save();
    }
    public void GameLoad()
    {
        if (!PlayerPrefs.HasKey("Day"))
        {
            Debug.Log("저장된 데이터가 없습니다.");
            return;
        }
        else
        {
            Debug.Log("데이터를 불러옵니다.");
        }

        int day = PlayerPrefs.GetInt("Day");
        string name = PlayerPrefs.GetString("Name");
        float Hilda_reliability = PlayerPrefs.GetFloat("Hilda_reliability");
        float Heather_reliability = PlayerPrefs.GetFloat("Heather_reliability");
        float Frances_reliability = PlayerPrefs.GetFloat("Frances_reliability");
        float Dylan_reliability = PlayerPrefs.GetFloat("Dylan_reliability");
        isGameOverInt = PlayerPrefs.GetInt("Gameover");
        citizenInt = PlayerPrefs.GetInt("Citizen");
        Frances_conversation_Int = PlayerPrefs.GetInt("Frances_conversation");
        Hilda_conversation_Int = PlayerPrefs.GetInt("Hilda_conversation");

        //if (isGameOverInt == 0) { isGameOver = true; }
        //else if (isGameOverInt == 1) { isGameOver = false; }

        if (citizenInt == 0) { citizen = true; }
        else if (citizenInt == 1) { citizen = false; }

        if (Frances_conversation_Int == 0) { Frances_conversation = true; }
        else if (Frances_conversation_Int == 1) { Frances_conversation = false; }

        if (Hilda_conversation_Int == 0) { Hilda_conversation = true; }
        else if (Frances_conversation_Int == 1) { Hilda_conversation = false; }

        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Day", day);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Hilda_reliability", Hilda_reliability);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Heather_reliability", Heather_reliability);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Frances_reliability", Frances_reliability);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability", Dylan_reliability);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetStringVariable("PlayerName", name);
        //GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Gameover", isGameOver);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Citizen", citizen);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Frances_conversation", Frances_conversation);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Hilda_conversation", Hilda_conversation);
    }

    public void GameInitialization()    //게임 초기화
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("게임 데이터를 초기화합니다...");
    }
}
