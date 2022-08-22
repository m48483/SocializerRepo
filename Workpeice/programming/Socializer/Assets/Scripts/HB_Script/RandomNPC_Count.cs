using Fungus;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNPC_Count : MonoBehaviour
{
    public void CitizenCount()
    {
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Citizen", GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Citizen") + 1);
        PlayerPrefs.SetInt("Citizen", GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Citizen"));
    }
    public void ReactionaryNPCCount()
    {
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("ReactionaryNPC", GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("ReactionaryNPC") + 1);
        PlayerPrefs.SetInt("ReactionaryNPC", GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("ReactionaryNPC"));
    }

    public void NPC_Pass()
    {
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Pass", GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Pass") + 1);
        PlayerPrefs.SetInt("Pass", GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Pass"));
        GameObject.Find("SayDialog").transform.Find("Evidence").GetComponent<Evidence>().TextInitialization();
        GameObject.Find("SayDialog").transform.Find("Panel").transform.Find("StoryText").GetComponent<Text_Clickable>().SetIndex();
    }
    public void NPC_Arrest()
    {
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Arrest", GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Arrest") + 1);
        PlayerPrefs.SetInt("Arrest", GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Arrest"));
        GameObject.Find("SayDialog").transform.Find("Evidence").GetComponent<Evidence>().TextInitialization();
        GameObject.Find("SayDialog").transform.Find("Panel").transform.Find("StoryText").GetComponent<Text_Clickable>().SetIndex();
    }
    public void NPC_Kill()
    {
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Kill", GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Kill") + 1);
        PlayerPrefs.SetInt("Kill", GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Kill"));
        GameObject.Find("SayDialog").transform.Find("Evidence").GetComponent<Evidence>().TextInitialization();
        GameObject.Find("SayDialog").transform.Find("Panel").transform.Find("StoryText").GetComponent<Text_Clickable>().SetIndex();
    }
}
