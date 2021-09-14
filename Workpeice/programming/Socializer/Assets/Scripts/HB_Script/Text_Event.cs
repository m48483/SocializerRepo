using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Event : MonoBehaviour
{
    public Text Conversation_text;
    public Text[] Observation_Text;
    public string[] str;
    public char[] separatorChar = {'\n'};


    public void Awake()
    {
        Conversation_text = gameObject.GetComponent<Text>();
       
        
    }
    public void Event()
    {
        str = Conversation_text.text.Split(separatorChar);
        Debug.Log(str[0]);
    }
}
