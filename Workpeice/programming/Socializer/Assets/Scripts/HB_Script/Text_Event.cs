using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Text_Event : MonoBehaviour
{
    public TextMeshProUGUI Conversation_text;
    public Text[] Observation_Text;
    public string[] str;
    
    public char[] separatorChar = { '.', '!', '?','\n' };

    public void Store()
    {
        Conversation_text = gameObject.GetComponent<TextMeshProUGUI>();
        str = Conversation_text.text.Split(separatorChar);

        for (int i = 0; i < str.Length; i++)
        {
            str[i] = str[i].Trim();
        }
    }
}
