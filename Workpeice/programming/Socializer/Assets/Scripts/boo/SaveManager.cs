using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SaveManager : MonoBehaviour
{
    public void GameSave()
    {
        PlayerPrefs.SetInt("Day", GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Day"));
        PlayerPrefs.SetFloat("Hilda_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability"));
        PlayerPrefs.SetFloat("Heather_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability"));
        PlayerPrefs.SetFloat("Frances_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability"));
        PlayerPrefs.SetFloat("Dylan_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));

        PlayerPrefs.Save();
    }
    public void GameLoad()
    {
        if (!PlayerPrefs.HasKey("Day"))
        {
            Debug.Log("저장된 데이터가 없습니다.");
            return;
        }

        int day = PlayerPrefs.GetInt("Day");
        string name = PlayerPrefs.GetString("Name");
        float Hilda_reliability = PlayerPrefs.GetFloat("Hilda_reliability");
        float Heather_reliability = PlayerPrefs.GetFloat("Heather_reliability");
        float Frances_reliability = PlayerPrefs.GetFloat("Frances_reliability");
        float Dylan_reliability = PlayerPrefs.GetFloat("Dylan_reliability");

        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Day", day);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Hilda_reliability", Hilda_reliability);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Heather_reliability", Heather_reliability);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Frances_reliability", Frances_reliability);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability", Dylan_reliability);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetStringVariable("PlayerName", name);
    }
}
