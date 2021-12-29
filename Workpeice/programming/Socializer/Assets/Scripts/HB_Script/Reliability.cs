using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reliability : MonoBehaviour
{
    float Hilda_reliability;
    float Heather_reliability;
    float Frances_reliability;
    string SceneName;// 씬이름 구별

    void Start()
    {
        Hilda_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability");
        Heather_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability");
        Frances_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability");
    }

    // Update is called once per frame
    public void Positive_conversation()
    {
        SceneName = SceneManager.GetActiveScene().name;

        if (SceneName.Equals("House"))
        {
            //Debug.Log(Heather_reliability);
            if (Hilda_reliability >= 80)
            {
                Heather_reliability = Heather_reliability + (Heather_reliability * (float)0.02);
            }
            else
            {
                Heather_reliability += (float)1.5;
                Debug.Log(Heather_reliability);
            }
            GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Heather_reliability", Heather_reliability);
        }
        else if (SceneName.Equals("Lobby"))
        {
            Hilda_reliability += 1;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Hilda_reliability", Hilda_reliability);
        }
        else if (SceneName.Equals("AM"))
        {
            Frances_reliability += 1;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Frances_reliability", Frances_reliability);
        }
    }

    public void Nagative_conversation()
    {
        SceneName = SceneManager.GetActiveScene().name;

        if (SceneName.Equals("House"))
        {
            //Debug.Log(Heather_reliability);
            if (Hilda_reliability <= 50)
            {
                Heather_reliability -= (float)1.5;
            }
            else
            {
                Heather_reliability -= (float)2.0;
                Debug.Log(Heather_reliability);
            }
            GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Heather_reliability", Heather_reliability);
        }
        else if (SceneName.Equals("Lobby"))
        {
            Hilda_reliability -= 2;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Hilda_reliability", Hilda_reliability);
        }
        else if (SceneName.Equals("AM"))
        {
            Frances_reliability -= 3;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Frances_reliability", Frances_reliability);
        }
    }
}
