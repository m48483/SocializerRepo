using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Evidence_Script : MonoBehaviour
{
    //public string[] Saved_conversation = new string[100];
    public Text Txt1;
    public Text Txt2;
    public Text Txt3;
    Text_Event TE;
    Evidence Ev;
    public int flag = 0;
    public int position = 0;
    public int page = 0;
    public int content_1 = 0;
    public int content_2 = 1;
    public int content_3 = 2;
    // Start is called before the first frame update

    public void Start()
    {
        
        
    }
    public void Activation()
    {
        Txt1 = GameObject.Find("Text(1)").GetComponent<Text>();
        Txt2 = GameObject.Find("Text(2)").GetComponent<Text>();
        Txt3 = GameObject.Find("Text(3)").GetComponent<Text>();
        Ev = GameObject.Find("Evidence").GetComponent<Evidence>();

        Debug.Log("시공");
    }

    public void E_onoff()
    {
        
        if (flag == 0)
        {
            Activation();
            flag = 1;           
        }
        Txt1.text = Ev.Saved_conversation[content_1];
        Txt2.text = Ev.Saved_conversation[content_2];
        Txt3.text = Ev.Saved_conversation[content_3];
    }

    public void L_Arrow()
    {
        if(position == 0)
        {

        }
        else if (position > 0)
        {
            Debug.Log("좌측이동");
            position--;
            content_1 -= 3; content_2 -= 3; content_3 -= 3;
            Txt1.text = Ev.Saved_conversation[content_1];
            Txt2.text = Ev.Saved_conversation[content_2];
            Txt3.text = Ev.Saved_conversation[content_3];
        }
    }

    public void R_Arrow()
    {
        Debug.Log("asdasd");

        if (position >= 0)
        {
            Debug.Log("우측이동");
            position++;
            content_1 += 3; content_2 += 3; content_3 += 3;
            Txt1.text = Ev.Saved_conversation[content_1];
            Txt2.text = Ev.Saved_conversation[content_2];
            Txt3.text = Ev.Saved_conversation[content_3];
        }
    }
}
