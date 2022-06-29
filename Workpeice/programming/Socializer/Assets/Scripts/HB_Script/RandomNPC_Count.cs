using Fungus;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNPC_Count : MonoBehaviour
{
    public int Pass;
    public int Arrest;
    public int kill;

    void Start()
    {
        Pass = 0;
        Arrest = 0;
        kill = 0;
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Pass", Pass);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Arrest", Arrest);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("kill", kill);
        //Daily_Schdule로 이동 시 초기화
    }

    public void NPC_Pass()
    {
        Pass++;
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Pass", Pass);
    }
    public void NPC_Arrest()
    {
        Arrest++;
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Arrest", Arrest);
    }
    public void NPC_Kill()
    {
        kill++;
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("kill", kill);
    }
}
