using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayStart : MonoBehaviour
{
    /// <summary>
    ///  임시로 작성한 스크립트 사용x
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        setVariables();
        Debug.Log("하루 시작\n대화 초기화");
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Heather_conversation", false);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Frances_conversation", false);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Hilda_conversation", false);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Dylan_conversation", false);
    }

    // Update is called once per frame
    public void setVariables()
    {
        GameObject.Find("Variables").GetComponent<Flowchart>().SetStringVariable("PlayerName",PlayerPrefs.GetString("PlayerName"));
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Daily_schedule",setBool(PlayerPrefs.GetInt("Daily_schedule")));
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Heather_conversation", setBool(PlayerPrefs.GetInt("Heather_conversation")));
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Hilda_conversation", setBool(PlayerPrefs.GetInt("Hilda_conversation")));
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Dylan_conversation", setBool(PlayerPrefs.GetInt("Dylan_conversation")));
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Frances_conversation", setBool(PlayerPrefs.GetInt("Frances_conversation")));
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Heather_reliability", PlayerPrefs.GetFloat("Heather_reliability"));
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Hilda_reliability", PlayerPrefs.GetFloat("Hilda_reliability"));
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability", PlayerPrefs.GetFloat("Dylan_reliability"));
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Frances_reliability", PlayerPrefs.GetFloat("Frances_reliability"));
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Day", PlayerPrefs.GetInt("Day"));
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Gameover", setBool(PlayerPrefs.GetInt("Gameover")));
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Revolutionary_route", setBool(PlayerPrefs.GetInt("Revolutionary_route")));

        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("ReactionaryNPC",0);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Citizen", 0);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Pass", 0);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Arrest", 0);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Kill", 0);

        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("RevolutionaryNPC", PlayerPrefs.GetFloat("RevolutionaryNPC"));
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("RevolutionaryPass", PlayerPrefs.GetFloat("RevolutionaryPass"));
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Tier1NPC", PlayerPrefs.GetFloat("Tier1NPC"));

    }

    public void SaveData()
    {
        PlayerPrefs.SetString("PlayerName", GameObject.Find("Variables").GetComponent<Flowchart>().GetStringVariable("PlayerName"));
        PlayerPrefs.SetInt("Daily_schedule", setInt(GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Daily_schdule")));
        PlayerPrefs.SetInt("Heather_conversation", setInt(GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Heather_conversation")));
        PlayerPrefs.SetInt("Hilda_conversation", setInt(GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Hilda_conversation")));
        PlayerPrefs.SetInt("Dylan_conversation", setInt(GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Dylan_conversation")));
        PlayerPrefs.SetInt("Frances_conversation", setInt(GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Frances_conversation")));
        PlayerPrefs.SetFloat("Heather_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability"));
        PlayerPrefs.SetFloat("Hilda_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability"));
        PlayerPrefs.SetFloat("Dylan_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));
        PlayerPrefs.SetFloat("Frances_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability"));
        PlayerPrefs.SetInt("Day", GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Day"));
        PlayerPrefs.SetInt("Gameover", setInt(GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Gameover")));
        PlayerPrefs.SetInt("Revolutionary_route", setInt(GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Revolutionary_route")));
        PlayerPrefs.SetInt("Day", GameObject.Find("ReactionaryNPC").GetComponent<Flowchart>().GetIntegerVariable("ReactionaryNPC"));
        PlayerPrefs.SetInt("Day", GameObject.Find("Citizen").GetComponent<Flowchart>().GetIntegerVariable("Citizen"));
        PlayerPrefs.SetInt("Day", GameObject.Find("Pass").GetComponent<Flowchart>().GetIntegerVariable("Pass"));
        PlayerPrefs.SetInt("Day", GameObject.Find("Arrest").GetComponent<Flowchart>().GetIntegerVariable("Arrest"));
        PlayerPrefs.SetInt("Day", GameObject.Find("Kill").GetComponent<Flowchart>().GetIntegerVariable("Kill"));
        PlayerPrefs.SetFloat("RevolutionaryNPC", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("RevolutionaryNPC"));
        PlayerPrefs.SetFloat("RevolutionaryPass", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("RevolutionaryPass"));
        PlayerPrefs.SetFloat("Tier1NPC", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Tier1NPC"));

        

    }

    public int setInt(bool _bool)
    {
        if (_bool)
            return 1;
        else if (_bool)
            return 0;

        return 1;

    }
    public bool setBool(int _bool)
    {
        if (_bool == 1)
            return true;
        else if (_bool == 0)
            return false;

        return true;
    }
}
