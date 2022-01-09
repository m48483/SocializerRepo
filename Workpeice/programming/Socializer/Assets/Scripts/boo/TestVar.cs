using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
using UnityEngine.SceneManagement;

public class TestVar : MonoBehaviour
{
    public GameObject goodBtn;
    public GameObject badBtn;
    public GameObject dayBtn;

    public Text reliabilityTxt;
    //public Text reliabilityTxt1;
    //public Text reliabilityTxt2;
    public Text dayTxt;

    int day;             //일차
    bool done;   //일과
    bool isGameOver;   //게임 오버
    int passPeople;   //통과시킨 반역자 수

    float Hilda_reliability;
    float Heather_reliability;
    float Frances_reliability;

    bool citizen;   //false시 사망
    bool Frances_conversation;   //AM 접촉시 true
    bool Hilda_conversation;   //정보부 NPC에게 이를 알림

    void Start()
    {
        day = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Day");
        isGameOver = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Gameover");
        Hilda_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability");
        Heather_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability");
        Frances_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability");
        Hilda_conversation = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Hilda_conversation");
        Frances_conversation = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Frances_conversation");
        
        passPeople = 2; //임시
        citizen = true;
        //Frances_conversation = false;
        //Hilda_conversation = false;

        switch (day % 7)
        {
            case 1:
                dayTxt.text = day + "일/월";
                break;
            case 2:
                dayTxt.text = day + "일/화";
                break;
            case 3:
                dayTxt.text = day + "일/수";
                break;
            case 4:
                dayTxt.text = day + "일/목";
                break;
            case 5:
                dayTxt.text = day + "일/금";
                break;
        }
        reliabilityTxt.text = "(" + Hilda_reliability + "/100)";  // 임시
    }

    // 신뢰도 메소드는 임시입니다.
    public void OnClickGood()
    {
        // 따로 메소드를 만들어야할 듯
        // 힐다 긍정적 대화 신뢰도
        if (Hilda_reliability >= 80)
        {
            Hilda_reliability = Hilda_reliability + (Hilda_reliability * 0.02f);
            Debug.Log("힐다 신뢰도 상승");
        }
        else
        {
            Hilda_reliability += 1.5f;
            Debug.Log("힐다 신뢰도 상승");
        }
        reliabilityTxt.text = "(" + (int)Hilda_reliability + "/100)";
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Hilda_reliability", Hilda_reliability);
    }
    public void OnClickBad()
    {
        // 힐다 부정적 대화 신뢰도
        if (Hilda_reliability <= 50)
        {
            Hilda_reliability -= 1.5f;
            Debug.Log("힐다 신뢰도 하락");
        }
        else
        {
            Hilda_reliability -= 2f;
            Debug.Log("힐다 신뢰도 하락");
        }
        reliabilityTxt.text = "(" + (int)Hilda_reliability + "/100)";
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Hilda_reliability", Hilda_reliability);
    }
    public void OnClickNextDay()
    {
        done = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Daily_schedule");
        if (done)   //일과를 마침, 다음 날로 이동 눌렀을 시
        {
            if (passPeople <= 7)
            {
                day++;
                GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Day", day);
                if (day == 61)
                {
                    Debug.Log("엔딩");
                    dayTxt.text = "Last Day";
                    LastDay();
                }
                else
                {
                    switch (day % 7)
                    {
                        case 1:
                            dayTxt.text = day + "일/월";
                            break;
                        case 2:
                            dayTxt.text = day + "일/화";
                            break;
                        case 3:
                            dayTxt.text = day + "일/수";
                            break;
                        case 4:
                            dayTxt.text = day + "일/목";
                            break;
                        case 5:
                            dayTxt.text = day + "일/금";
                            day += 2;
                            break;
                    }
                }
                done = false;
                GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Daily_schedule", done);
            }
            else
            {
                isGameOver = true;
                GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Gameover", isGameOver);
                Debug.Log("게임오버");
            }
        }
    }
    void LastDay()
    {
        if (Hilda_reliability == 0 || passPeople == 7 || citizen == false)
        {
            Ending1();
        }
        else if (Frances_conversation == false || Hilda_reliability < 90)
        {
            Ending2();
        }
        else if (Frances_conversation == false || Hilda_reliability >= 90)
        {
            Ending3();
        }
        else if (Frances_conversation == true || Frances_reliability < 40)
        {
            Ending4();
        }
        else if (Frances_conversation == true || Frances_reliability >= 80 || Hilda_conversation == true)
        {
            Ending5();
        }
        else if (Frances_conversation == true || Frances_reliability >= 80 || Hilda_conversation == false)
        {
            Ending6();
        }
        else if (Frances_conversation == false || (Frances_reliability >= 40 && Frances_reliability < 80))
        {
            Ending7();
        }
    }

    void Ending1()
    {
        isGameOver = true;
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Gameover", isGameOver);
        SceneManager.LoadScene("Ending1");
    }
    void Ending2()
    {
        SceneManager.LoadScene("Ending2");
    }
    void Ending3()
    {
        SceneManager.LoadScene("Ending3");
    }
    void Ending4()
    {
        SceneManager.LoadScene("Ending4");
    }
    void Ending5()
    {
        SceneManager.LoadScene("Ending5");
    }
    void Ending6()
    {
        SceneManager.LoadScene("Ending6");
    }
    void Ending7()
    {
        SceneManager.LoadScene("Ending7");
    }
}