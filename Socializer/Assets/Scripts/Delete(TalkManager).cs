using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TalkManager : MonoBehaviour
{
    public Button TalkButton1, TalkButton2;
    public GameObject TalkUI;
    public Text TalkText;
    enum State { good,bad};


    public string[] Talkread = { "당신을 기다리고 있었어.", "새로운 정보를 가지고 왔어?", "실망이군" };


    void Start()
    {
        Button click1 = TalkButton1.GetComponent<Button>();
        Button click2 = TalkButton2.GetComponent<Button>();
        click1.onClick.AddListener(envisiable);
        click1.onClick.AddListener(goodchoice);
        click2.onClick.AddListener(envisiable);
        click2.onClick.AddListener(badchoice);
        Talk();
    }
    void Update()
    {
        
        
    }
    public void Talk()
    {
        TalkText.text = Talkread[0];
    }
    public void envisiable()
    {
        TalkButton1.gameObject.SetActive(false);
        TalkButton2.gameObject.SetActive(false);
    }
    public void goodchoice()
    {
        TalkText.text = Talkread[1];
    }
    public void badchoice()
    {
        TalkText.text = Talkread[2];
    }
    
}
