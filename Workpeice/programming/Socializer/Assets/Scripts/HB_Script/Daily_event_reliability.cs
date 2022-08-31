using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


public class Daily_event_reliability : MonoBehaviour
{
    float Hilda_reliability;
    float Heather_reliability;
    float Frances_reliability;
    float Dylan_reliability;

    public void Day17_1()
    {

        Frances_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability");
        Frances_reliability += 5;
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Frances_reliability", Frances_reliability);

    }
    public void Day17_2()
    {

        Frances_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability");
        Frances_reliability -= 5;
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Frances_reliability", Frances_reliability);

    }
    public void Day18_1()
    {

        Frances_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability");
        Frances_reliability += 5;
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Frances_reliability", Frances_reliability);

    }
    public void Day18_2()
    {

        Frances_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability");
        Frances_reliability -= 5;
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Frances_reliability", Frances_reliability);
        
    }

}