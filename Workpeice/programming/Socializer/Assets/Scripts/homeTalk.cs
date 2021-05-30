using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class homeTalk : MonoBehaviour
{
    public Button TalkButton1, TalkButton2, TalkButton3, MoveButton;
    public GameObject TalkUI;
    public Text TalkText;

    enum State { good, bad, rest };


    public string[] Talkread = { "다녀오셨어요!", "제 이야기를 잘 들어주셔서 좋아요!", "왜 그런 말을 하시는지 모르겠어요.", "안녕히 주무세요!" };

    void Start()
    {
        Button click1 = TalkButton1.GetComponent<Button>();
        Button click2 = TalkButton2.GetComponent<Button>();
        Button click3 = TalkButton3.GetComponent<Button>();
        Button click4 = MoveButton.GetComponent<Button>();
        click1.onClick.AddListener(envisiable);
        click1.onClick.AddListener(goodChoice);
        click2.onClick.AddListener(envisiable);
        click2.onClick.AddListener(badChoice);
        click3.onClick.AddListener(envisiable);
        click3.onClick.AddListener(restChoice);
        click4.onClick.AddListener(envisiable);
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
    public void goodChoice()
    {
        TalkText.text = Talkread[1];
    }
    public void badChoice()
    {
        TalkText.text = Talkread[2];
    }
    public void restChoice()
    {
        TalkText.text = Talkread[3];
        TalkButton3.gameObject.SetActive(false);
    }
}
