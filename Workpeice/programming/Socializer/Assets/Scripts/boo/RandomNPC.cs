using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class RandomNPC : MonoBehaviour
{
    int day;             //일차
    int reactionaryNPC;    //반동분다
    int citizen;        //일반 시민
    int max;
    int number;

    // Start is called before the first frame update
    void Start()
    {
        day = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Day");
        //reactionaryNPC = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("ReactionaryNPC");
        //citizen = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Citizen");
        
        if (day >= 1 && day < 6)
        {
            reactionaryNPC = 1;
            citizen = 1;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("ReactionaryNPC", reactionaryNPC);
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Citizen", citizen);

        }
        else if (day >= 8 && day < 13)
        {
            number = Random.Range(2, 3);
            max = number;   // 최대 NPC 등장 수
            number = Random.Range(1, max);
            reactionaryNPC = number;
            citizen = max - reactionaryNPC;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("ReactionaryNPC", reactionaryNPC);
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Citizen", citizen);
        }
    }
}
