using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text_Clickable : MonoBehaviour
{
    public TextMeshProUGUI text;
    Text_Event TE;
    public string LastClickedWord;
    public static int Store_index = 0;
    public static string[] Saved_conversation = new string[100];

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TE = GameObject.Find("StoryText").GetComponent<Text_Event>();
            var wordIndex = TMP_TextUtilities.FindIntersectingWord(text, Input.mousePosition, null);
            //Debug.Log("Clicked on " + wordIndex);
            if (wordIndex != -1)
            {                
                LastClickedWord = text.textInfo.wordInfo[wordIndex].GetWord();
                for(int i = 0; i < TE.str.Length; i++)
                {
                    if (TE.str[i].IndexOf(LastClickedWord) != -1)
                    {
                        Debug.Log(TE.str[i]);
                        Saved_conversation[Store_index] = TE.str[i];
                        Store_index += 1;
                    }
                }
                Debug.Log("Clicked on " + LastClickedWord);
            }
        }
    }
}
