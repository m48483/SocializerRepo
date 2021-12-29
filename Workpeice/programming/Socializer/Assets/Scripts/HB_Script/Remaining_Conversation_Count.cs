using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class Remaining_Conversation_Count : MonoBehaviour
{
    public Text test;
    int num;
    public void Get_Num()
    {
        num = GameObject.Find("Flowchart").GetComponent<Flowchart>().GetIntegerVariable("Conversation_Count");
        test.text = num.ToString();
    }

    public void Set_Num()
    {
        num -= 1;
        GameObject.Find("Flowchart").GetComponent<Flowchart>().SetIntegerVariable("Conversation_Count", num);
        test.text = num.ToString();
    }
}
