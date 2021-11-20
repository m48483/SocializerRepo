using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VarManager : MonoBehaviour
{
    public GameObject goodBtn;
    public GameObject badBtn;
    public GameObject dayBtn;

    public Text reliabilityTxt;
    public Text dayTxt;

    public int day;
    public float reliability;

    void Awake()
    {
        switch (day % 7)
        {
            case 0:
                dayTxt.text = day + "일/일";
                break;
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
            case 6:
                dayTxt.text = day + "일/토";
                break;
        }
        reliabilityTxt.text = "(" + reliability + "/100)";
    }

    public void OnClickGood()
    {
        if (reliability >= 80)
            reliability = reliability + (reliability * 0.02f);
        else
            reliability += 1.5f;
        reliabilityTxt.text = "(" + (int)reliability + "/100)";
    }
    public void OnClickBad()
    {
        if (reliability <= 50)
            reliability -= 1.5f;
        else
            reliability -= 2f;
        reliabilityTxt.text = "(" + (int)reliability + "/100)";
    }
    public void OnClickNextDay()
    {
        if (day >= 61)
        {
            Debug.Log("엔딩");
            dayTxt.text = "Last Day";
        }
        else
        {
            day++;
            switch (day % 7)
            {
                case 0:
                    dayTxt.text = day + "일/일";
                    break;
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
                case 6:
                    dayTxt.text = day + "일/토";
                    break;
            }
            //dayTxt.text = "Day" + day;
        }

    }
}
