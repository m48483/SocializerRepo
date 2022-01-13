using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class Remaining_Conversation_Count : MonoBehaviour
{
    public Text test;
    int num1, num2;
    string str;
    public void Get_Num()
    {
        num1 = GameObject.Find("Flowchart").GetComponent<Flowchart>().GetIntegerVariable("Conversation_Count");
        num2 = GameObject.Find("Flowchart").GetComponent<Flowchart>().GetIntegerVariable("Max");
        str = "(" + num1 + "/" + num2 + ")";
        test.text = str;
    }

    public void Set_Num()
    {
        num1++;
        GameObject.Find("Flowchart").GetComponent<Flowchart>().SetIntegerVariable("Conversation_Count", num1);
        str = "(" + num1 + "/" + num2 + ")";
        test.text = str;
    }
}
