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
        dayTxt.text = "Day" + day;
        reliabilityTxt.text = reliability + "/100";
    }

    public void OnClickGood()
    {
        if (reliability >= 80)
            reliability = reliability + (reliability * 0.02f);
        else
            reliability += 1.5f;
        reliabilityTxt.text = (int)reliability + "/100";
    }
    public void OnClickBad()
    {
        if (reliability <= 50)
            reliability -= 1.5f;
        else
            reliability -= 2f;
        reliabilityTxt.text = (int)reliability + "/100";
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
            dayTxt.text = "Day" + day;
        }

    }
}
