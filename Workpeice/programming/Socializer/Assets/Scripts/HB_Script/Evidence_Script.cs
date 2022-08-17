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
    public string message1, message2, message3;
    // Start is called before the first frame update


    NoticeUI _notice;

    void Awake()
    {
        _notice = FindObjectOfType<NoticeUI>();
    }

    public void Activation()
    {
        Txt1 = GameObject.Find("Text(1)").GetComponent<Text>();
        Txt2 = GameObject.Find("Text(2)").GetComponent<Text>();
        Txt3 = GameObject.Find("Text(3)").GetComponent<Text>();
        Ev = GameObject.Find("Evidence").GetComponent<Evidence>();
    }

    public void E_onoff()
    {
        message1 = GameObject.Find("Evidence").GetComponent<Evidence>().Saved_conversation[0];
        message2 = GameObject.Find("Evidence").GetComponent<Evidence>().Saved_conversation[1];
        message3 = GameObject.Find("Evidence").GetComponent<Evidence>().Saved_conversation[2];
        
        _notice.SUB(message1, message2, message3);
    }
    

    //폐기
    /*
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
    */
}
