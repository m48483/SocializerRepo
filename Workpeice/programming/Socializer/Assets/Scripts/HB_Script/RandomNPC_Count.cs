using Fungus;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNPC_Count : MonoBehaviour
{
    Reactionary_Check RC;
    int Pass;
    int Arrest;
    int kill;

    void Start()
    {
        Pass = 0;
        Arrest = 0;
        kill = 0;
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
