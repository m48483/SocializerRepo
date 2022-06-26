using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Call_RandomNPC : MonoBehaviour
{
    int day;             //일차
    public int reactionaryNPC;    //반동분자
    public int citizen;        //일반 시민
    int max;
    int number;

    bool RevolutionaryNPC;  // 혁명단원 등장
    bool RevolutionaryPass;  // 혁명단원 통과
    bool Revolutionary_route;  // 혁명루트
    bool Tier1NPC;          // 1계층시민 등장


    // Start is called before the first frame update
    public void Start()
    {
        
    }
    public void setCount()
    {
        reactionaryNPC = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("ReactionaryNPC");
        citizen = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Citizen");

        callNPC();
    }

    // Update is called once per frame
    void callNPC()
    {
        int num = Random.Range(0, 2); // 0 = 반동분자, 1 = 시티즌

        switch (num)
        {
            case 0:
                callreactionaryNPC();
                break;
            case 1:
                callcitizen();
                break;
        }
    }

    void callreactionaryNPC()
    {
        if(reactionaryNPC == 0)
        {
            if (citizen == 0)
            {
                GameObject.Find("FC").transform.Find("Schedule_end").gameObject.SetActive(true);
            }
            else if (citizen != 0)
                callNPC();
                
        }
        else if (reactionaryNPC > 0)
        {
            int num = Random.Range(1, 4);
            GameObject.Find("FC").transform.Find("ReactionaryNPC").transform.Find("ReactionaryNPC" + num).gameObject.SetActive(true);
            reactionaryNPC--;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("ReactionaryNPC", reactionaryNPC);
        }
    }

    void callcitizen()
    {
        if (citizen == 0)
        {
            if (reactionaryNPC == 0)
            {
                GameObject.Find("FC").transform.Find("Schedule_end").gameObject.SetActive(true);
            }
            else if (reactionaryNPC != 0)
                callNPC();

        }
        else if (citizen > 0)
        {
            int num = Random.Range(1, 4);
            GameObject.Find("FC").transform.Find("Citizen").transform.Find("Citizen" + num).gameObject.SetActive(true);
            citizen--;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Citizen", citizen);
        }
    }

    public void DailyScheduleEnd()
    {
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Daily_schedule", true);
    }

}
