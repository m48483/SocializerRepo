using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;

public class Text_Event : MonoBehaviour
{
    public TextMeshProUGUI Conversation_text;
    public Text[] Observation_Text;
    public string[] str;
    public int num;
    public int[,] starttoend_index = new int[1000, 2];

    public void Store()
    {
        num = 0;
        Conversation_text = gameObject.GetComponent<TextMeshProUGUI>();
        str = Conversation_text.text.Split(new string[] {"\n"}, System.StringSplitOptions.RemoveEmptyEntries);
        //str = Conversation_text.text.Split(new string[] { "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
        MatchCollection matches;
        for (int i = 0; i < str.Length; i++)
        {
            str[i] = str[i].Trim();
            Debug.Log(str[i]);
        }
        for (int i = 0; i < str.Length; i++)
        {
            matches = Regex.Matches(str[i], " ");
            starttoend_index[i, 0] = num;
            
            starttoend_index[i, 1] = matches.Count + num;
            num += matches.Count + 1;
            Debug.Log(i + "번째" + starttoend_index[i, 0]);
            Debug.Log(i + "번째" + starttoend_index[i, 1]);
        }

    }
}
