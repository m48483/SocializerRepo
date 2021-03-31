using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class officeManager : MonoBehaviour
{
    public Button TalkButton1, TalkButton2, TalkButton3, TalkButton4, TalkButton5, TalkButton6, TalkButton7, TalkButton8, TalkButton9, MoveButton;
    public GameObject TalkUI;
    public Text TalkText;
    enum State { good, bad };


    public string[] Talkread = { "안녕하세요!", "얘기 들어줘서 감사합니다!", "왜 그런 말을 하시는지 모르겠어요.", "감사합니다.", "(강압적 대화)", "행동", "통과", "구속", "사살" };

    // Start is called before the first frame update
    void Start()
    {
        Button click1 = TalkButton1.GetComponent<Button>();
        Button click2 = TalkButton2.GetComponent<Button>();
        Button click3 = TalkButton3.GetComponent<Button>();
        Button click4 = TalkButton4.GetComponent<Button>();
        Button click5 = TalkButton5.GetComponent<Button>();
        Button click6 = TalkButton6.GetComponent<Button>();
        Button click7 = TalkButton7.GetComponent<Button>();
        Button click8 = TalkButton8.GetComponent<Button>();
        Button click9 = TalkButton9.GetComponent<Button>();
        Button click10 = MoveButton.GetComponent<Button>();

        click1.onClick.AddListener(goodChoice);
        click2.onClick.AddListener(badChoice);
        click3.onClick.AddListener(conciliateChoice);
        click4.onClick.AddListener(coerciveChoice);
        click5.onClick.AddListener(observation);
        click6.onClick.AddListener(behavior);
        click7.onClick.AddListener(pass);
        click8.onClick.AddListener(arrest);
        click9.onClick.AddListener(dead);
        click10.onClick.AddListener(dead);

        //click4.onClick.AddListener(envisiable);
        startMsg();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startMsg()
    {
        TalkText.text = Talkread[0];
        TalkButton5.gameObject.SetActive(false);
        TalkButton6.gameObject.SetActive(false);
        TalkButton7.gameObject.SetActive(false);
        TalkButton8.gameObject.SetActive(false);
        TalkButton9.gameObject.SetActive(false);
        MoveButton.gameObject.SetActive(false);
    }
    public void envisiable()
    {
        TalkButton1.gameObject.SetActive(false);
        TalkButton2.gameObject.SetActive(false);
        TalkButton3.gameObject.SetActive(false);
        TalkButton4.gameObject.SetActive(false);
    }
    public void goodChoice()
    {
        TalkText.text = Talkread[1];
        envisiable();
        TalkButton5.gameObject.SetActive(true);
    }
    public void badChoice()
    {
        TalkText.text = Talkread[2];
        envisiable();
        TalkButton5.gameObject.SetActive(true);
    }
    public void conciliateChoice()
    {
        TalkText.text = Talkread[3];
        envisiable();
        TalkButton5.gameObject.SetActive(true);
    }
    public void coerciveChoice()
    {
        TalkText.text = Talkread[4];
        TalkButton5.gameObject.SetActive(true);
    }
    public void observation()
    {
        TalkText.text = Talkread[5];
        TalkButton6.gameObject.SetActive(true);
    }
    public void behavior()
    {
        envisiable();
        TalkButton7.gameObject.SetActive(true);
        TalkButton8.gameObject.SetActive(true);
        TalkButton9.gameObject.SetActive(true);
    }
    public void pass()
    {
        TalkText.text = Talkread[6];
        envisiable();
        TalkButton5.gameObject.SetActive(false);
        TalkButton6.gameObject.SetActive(false);
        TalkButton7.gameObject.SetActive(false);
        TalkButton8.gameObject.SetActive(false);
        TalkButton9.gameObject.SetActive(false);
        MoveButton.gameObject.SetActive(true);
    }
    public void arrest()
    {
        TalkText.text = Talkread[7];
        envisiable();
        TalkButton5.gameObject.SetActive(false);
        TalkButton6.gameObject.SetActive(false);
        TalkButton7.gameObject.SetActive(false);
        TalkButton8.gameObject.SetActive(false);
        TalkButton9.gameObject.SetActive(false);
        MoveButton.gameObject.SetActive(true);
    }
    public void dead()
    {
        TalkText.text = Talkread[8];
        envisiable();
        TalkButton5.gameObject.SetActive(false);
        TalkButton6.gameObject.SetActive(false);
        TalkButton7.gameObject.SetActive(false);
        TalkButton8.gameObject.SetActive(false);
        TalkButton9.gameObject.SetActive(false);
        MoveButton.gameObject.SetActive(true);
    }
    public void moveLobby()
    {
        MoveButton.gameObject.SetActive(false);
    }
}
