using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class RandomNPC : MonoBehaviour
{
    TestVar testVar;
    public GameObject callNPC;
    int day;             //일차
    int reactionaryNPC;    //반동분자
    int citizen;        //일반 시민
    int max;
    int number;

    bool RevolutionaryNPC;  // 혁명단원 등장
    bool RevolutionaryPass;  // 혁명단원 통과
    bool Revolutionary_route;  // 혁명루트
    bool Tier1NPC;          // 1계층시민 등장

    // Start is called before the first frame update
    void Start()
    {
        day = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Day");
        //reactionaryNPC = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("ReactionaryNPC");
        //citizen = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Citizen");
        
        if (day >= 1 && day < 6)            // 1~5일차
        {
            reactionaryNPC = 1;
            citizen = 1;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("ReactionaryNPC", reactionaryNPC);
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Citizen", citizen);
            callNPC.gameObject.GetComponent<Call_RandomNPC>().setCount();
        }
        else if (day >= 8 && day < 13)      // 8~12일차
        {
            if (day == 12)
            {
                RevolutionaryNPC = true;
                GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("RevolutionaryNPC", RevolutionaryNPC);
            }
            else
            {
                RevolutionaryNPC = false;
                GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("RevolutionaryNPC", RevolutionaryNPC);
            }

            number = Random.Range(2, 3);
            max = number;   // 최대 NPC 등장 수
            number = Random.Range(1, max);
            reactionaryNPC = number;
            citizen = max - reactionaryNPC;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("ReactionaryNPC", reactionaryNPC);
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Citizen", citizen);
        }
        else if(day >= 15 && day < 20)      // 15~19일차
        {
            if (day == 17)
            {
                RevolutionaryNPC = true;
                GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("RevolutionaryNPC", RevolutionaryNPC);

                RevolutionaryPass = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("RevolutionaryPass");
                if (RevolutionaryPass)  //혁명루트
                {
                    Revolutionary_route = true;
                    GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Revolutionary_route", Revolutionary_route);
                }
            }
            else
            {
                RevolutionaryNPC = false;
                GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("RevolutionaryNPC", RevolutionaryNPC);
            }

            if (day == 19)
            {
                Tier1NPC = true;
                GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Tier1NPC", Tier1NPC);
            }

            max = 3;   // 최대 NPC 등장 수
            number = Random.Range(1, max);
            reactionaryNPC = number;
            citizen = max - reactionaryNPC;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("ReactionaryNPC", reactionaryNPC);
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Citizen", citizen);
        }
        else if (day >= 22 && day < 27)      // 22~26일차
        {
            if (day == 23)
            {
                Revolutionary_route = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Revolutionary_route");
                if (Revolutionary_route)
                {
                    RevolutionaryNPC = true;
                    GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("RevolutionaryNPC", RevolutionaryNPC);
                }
                else
                {
                    number = Random.Range(3, 4);
                    max = number;   // 최대 NPC 등장 수
                    number = Random.Range(1, max);
                    reactionaryNPC = number;
                    citizen = max - reactionaryNPC;
                }
            }
            else
            {
                RevolutionaryNPC = false;
                GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("RevolutionaryNPC", RevolutionaryNPC);
            }

            if (day == 25)
            {
                Tier1NPC = true;
                GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Tier1NPC", Tier1NPC);
            }

            number = Random.Range(3, 4);
            max = number;   // 최대 NPC 등장 수
            number = Random.Range(1, max);
            reactionaryNPC = number;
            citizen = max - reactionaryNPC;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("ReactionaryNPC", reactionaryNPC);
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Citizen", citizen);
        }
        else if (day >= 29 && day < 34)      // 29~33일차
        {
            max = 4;   // 최대 NPC 등장 수
            number = Random.Range(1, max);
            reactionaryNPC = number;
            citizen = max - reactionaryNPC;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("ReactionaryNPC", reactionaryNPC);
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Citizen", citizen);
        }
        else if (day >= 36 && day < 41)      // 36~40일차
        {
            number = Random.Range(4, 5);
            max = number;   // 최대 NPC 등장 수
            number = Random.Range(1, max);
            reactionaryNPC = number;
            citizen = max - reactionaryNPC;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("ReactionaryNPC", reactionaryNPC);
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Citizen", citizen);
        }
        else if (day >= 43 && day < 48)      // 43~47일차
        {
            max = 5;   // 최대 NPC 등장 수
            number = Random.Range(1, max);
            reactionaryNPC = number;
            citizen = max - reactionaryNPC;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("ReactionaryNPC", reactionaryNPC);
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Citizen", citizen);
        }
        else if (day >= 50 && day < 55)      // 50~54일차
        {
            number = Random.Range(5, 6);
            max = number;   // 최대 NPC 등장 수
            number = Random.Range(1, max);
            reactionaryNPC = number;
            citizen = max - reactionaryNPC;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("ReactionaryNPC", reactionaryNPC);
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Citizen", citizen);
        }
        else if (day >= 57 && day < 61)      // 57~60일차
        {
            if (day == 59)
            {
                Revolutionary_route = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Revolutionary_route");
                if (Revolutionary_route)
                {
                    RevolutionaryNPC = true;
                    GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("RevolutionaryNPC", RevolutionaryNPC);
                }
                else
                {
                    max = 6;   // 최대 NPC 등장 수
                    number = Random.Range(1, max);
                    reactionaryNPC = number;
                    citizen = max - reactionaryNPC;
                }
            }
            else
            {
                RevolutionaryNPC = false;
                GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("RevolutionaryNPC", RevolutionaryNPC);
            }

            if (day == 25)
            {
                Tier1NPC = true;
                GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Tier1NPC", Tier1NPC);
            }

            max = 6;   // 최대 NPC 등장 수
            number = Random.Range(1, max);
            reactionaryNPC = number;
            citizen = max - reactionaryNPC;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("ReactionaryNPC", reactionaryNPC);
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Citizen", citizen);
        }
        else if (day == 61)
        {
            testVar.LastDay();
        }
    }
}
