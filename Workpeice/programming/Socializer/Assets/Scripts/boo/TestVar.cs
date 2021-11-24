using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestVar : MonoBehaviour
{
    public GameObject goodBtn;
    public GameObject badBtn;
    public GameObject dayBtn;

    public Text reliabilityTxt0;
    //public Text reliabilityTxt1;
    //public Text reliabilityTxt2;
    public Text dayTxt;

    public int day;             //일차
    public bool done;   //일과
    public float[] reliability = new float[3];     //신뢰도
    // 0 자녀 1중앙정보부 2AM

    public struct Var      //하루가 지나면 변경 or 초기화될 것들
    {
        //static public float reliability;     //신뢰도
        //static public bool done;   //일과
        static public bool isGameOver;   //게임 오버
        static public int passPeople;   //통과시킨 반연자 수
        //static public string[] evidence; //증거
    }
    // Start is called before the first frame update
    void Start()
    {
        Var.passPeople = 2;
        switch (day % 7)
        {
            case 1:
                dayTxt.text = day + "일차/월";
                break;
            case 2:
                dayTxt.text = day + "일차/화";
                break;
            case 3:
                dayTxt.text = day + "일차/수";
                break;
            case 4:
                dayTxt.text = day + "일차/목";
                break;
            case 5:
                dayTxt.text = day + "일차/금";
                break;
        }
        reliabilityTxt0.text = "(" + reliability[0] + "/100)";
        //reliabilityTxt1.text = "(" + reliability[1] + "/100)";
        //reliabilityTxt2.text = "(" + reliability[2] + "/100)";
    }

    // Update is called once per frame
    void Update()
    {
        




    }
    public void OnClickGood()
    {
        // 따로 메소드를 만들어야할 듯
        // 자녀 긍정적 대화 신뢰도
        if (reliability[1] >= 80)
        {
            reliability[0] = reliability[0] + (reliability[0] * 0.02f);
            Debug.Log("자녀 신뢰도 상승");
        }
        else
        {
            reliability[0] += 1.5f;
            Debug.Log("자녀 신뢰도 상승");
        }
        reliabilityTxt0.text = "(" + (int)reliability[0] + "/100)";
    }
    public void OnClickBad()
    {
        // 자녀 부정적 대화 신뢰도
        if (reliability[1] <= 50)
        {
            reliability[0] -= 1.5f;
            Debug.Log("자녀 신뢰도 하락");
        }
        else
        {
            reliability[0] -= 2f;
            Debug.Log("자녀 신뢰도 하락");
        }
        reliabilityTxt0.text = "(" + (int)reliability[0] + "/100)";
    }
    public void OnClickNextDay()
    {
        if (done)   //일과를 마침, 다음 날로 이동 눌렀을 시
        {
            if (Var.passPeople <= 7)
            {
                day++;
                if (day >= 61)
                {
                    Debug.Log("엔딩");
                    dayTxt.text = "Last Day";
                }
                else
                {
                    switch (day % 7)
                    {
                        case 1:
                            dayTxt.text = day + "일차/월";
                            break;
                        case 2:
                            dayTxt.text = day + "일차/화";
                            break;
                        case 3:
                            dayTxt.text = day + "일차/수";
                            break;
                        case 4:
                            dayTxt.text = day + "일차/목";
                            break;
                        case 5:
                            dayTxt.text = day + "일차/금";
                            day += 2;
                            break;
                    }
                }
                done = false;
            }
            else
            {
                Var.isGameOver = true;
                Debug.Log("게임오버");
            }
        }
    }
}