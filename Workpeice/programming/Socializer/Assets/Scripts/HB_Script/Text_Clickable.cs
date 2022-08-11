using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text_Clickable : MonoBehaviour
{
    public TextMeshProUGUI text;
    string tmptext;
    Text_Event TE;
    Evidence E;
    public string LastClickedWord;
    public static int Store_index = 0;
    public int flag;
    public int i;
    int wordIndex = -1;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TE = GameObject.Find("StoryText").GetComponent<Text_Event>();
            E = GameObject.Find("Evidence").GetComponent<Evidence>();
            wordIndex = TMP_TextUtilities.FindIntersectingWord(text, Input.mousePosition, null);

            Debug.Log("asd" + wordIndex);
            //Debug.Log("Clicked on " + wordIndex);
            if (wordIndex != -1)
            { 
                flag = 0;
                LastClickedWord = text.textInfo.wordInfo[wordIndex].GetWord();
                Debug.Log(TE.starttoend_index[1, 0]);
                for (i = 0; i < TE.str.Length; i++)
                {
                    if (TE.str[i].IndexOf(LastClickedWord) != -1 && TE.starttoend_index[i, 0] <= wordIndex && TE.starttoend_index[i, 1] >= wordIndex)
                    {
                        Debug.Log(TE.str[i]);

                        if(Store_index < 3)
                        {
                            //증거 중복체크
                            for (int a = 0; a < Store_index; a++)
                            {
                                if (E.Saved_conversation[a] == TE.str[i])
                                {
                                    flag = 1;
                                }
                            }

                            if (flag == 0)
                            {
                                E.Saved_conversation[Store_index] = TE.str[i];
                                E.size++;
                                Store_index += 1;
                            }
                        }
                        
                        else if(Store_index >= 3)
                        {
                            Debug.Log("저장초과");
                        }
                        tmptext = text.text;
                        text.text = "<color=#FFEA0F>" + text.text + "</color>";
                        

                        /* 위에 한 줄이면 해결할 것을 난 왜 이렇게 했을까,,,,,
                        // 텍스트 색깔
                        for (int j = 0; j < text.textInfo.wordCount; j++)
                        {
                            TMP_WordInfo info = text.textInfo.wordInfo[j];
                            for (int a = 0; a < info.characterCount; ++a)
                            {
                                int charIndex = info.firstCharacterIndex + a;
                                int meshIndex = text.textInfo.characterInfo[charIndex].materialReferenceIndex;
                                int vertexIndex = text.textInfo.characterInfo[charIndex].vertexIndex;

                                Color32[] vertexColors = text.textInfo.meshInfo[meshIndex].colors32;
                                vertexColors[vertexIndex + 0] = new Color32(255, 204, 24, 255);
                                vertexColors[vertexIndex + 1] = new Color32(255, 204, 24, 255);
                                vertexColors[vertexIndex + 2] = new Color32(255, 204, 24, 255);
                                vertexColors[vertexIndex + 3] = new Color32(255, 204, 24, 255);
                            }

                            text.UpdateVertexData(TMP_VertexDataUpdateFlags.All);
                        }
                        */
                        break;
                    }    
                }
                Debug.Log("Clicked on " + LastClickedWord);
               
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if(wordIndex != -1)
            {
                text.text = tmptext;
                wordIndex = -1;
            }
            /* 위에 한 줄이면 해결할 것을 난 왜 이렇게 했을까,,,,,
            // 텍스트 색깔
            for (int j = 0; j <= text.textInfo.wordCount; j++)
            {
                TMP_WordInfo info = text.textInfo.wordInfo[j];
                for (int a = 0; a < info.characterCount; ++a)
                {
                    int charIndex = info.firstCharacterIndex + a;
                    int meshIndex = text.textInfo.characterInfo[charIndex].materialReferenceIndex;
                    int vertexIndex = text.textInfo.characterInfo[charIndex].vertexIndex;

                    Color32[] vertexColors = text.textInfo.meshInfo[meshIndex].colors32;
                    vertexColors[vertexIndex + 0] = new Color32(255, 255, 255, 255);
                    vertexColors[vertexIndex + 1] = new Color32(255, 255, 255, 255);
                    vertexColors[vertexIndex + 2] = new Color32(255, 255, 255, 255);
                    vertexColors[vertexIndex + 3] = new Color32(255, 255, 255, 255);
                }

                text.UpdateVertexData(TMP_VertexDataUpdateFlags.All);
            }
            */
        }
    }
}
