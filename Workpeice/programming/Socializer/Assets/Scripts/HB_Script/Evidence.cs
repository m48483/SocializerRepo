using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Evidence : MonoBehaviour
{
    public string[] Saved_conversation = new string[3];
    public int size = 0;

    public void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            Saved_conversation[i] = " ";
        }
    }
    public void Evidence_ERROR()
    {

    }
}
