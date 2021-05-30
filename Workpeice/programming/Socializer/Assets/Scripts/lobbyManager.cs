using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviour
{
    public Button moveButton, talkButton, goodTalk, badTalk;
    void Start()
    {
        Button click1_1 = talkButton.GetComponent<Button>();
        Button click1_2 = moveButton.GetComponent<Button>();
        Button click2_1 = goodTalk.GetComponent<Button>();
        Button click2_2 = badTalk.GetComponent<Button>();

        click1_1.onClick.AddListener(envisiable);
        click1_1.onClick.AddListener(talkChoice);
        click1_2.onClick.AddListener(envisiable);
        click1_2.onClick.AddListener(moveChoice);
        click2_1.onClick.AddListener(envisiable);
        click2_1.onClick.AddListener(goodChoice);
        click2_2.onClick.AddListener(envisiable);
        click2_2.onClick.AddListener(badChoice);
    }


    public void envisiable()
    {
        talkButton.gameObject.SetActive(false);
        moveButton.gameObject.SetActive(false);
    }
    public void moveChoice()
    {
        talkButton.gameObject.SetActive(false);
        moveButton.gameObject.SetActive(false);
        goodTalk.gameObject.SetActive(false);
        badTalk.gameObject.SetActive(false);
    }
    public void talkChoice()
    {
        talkButton.gameObject.SetActive(false);
        moveButton.gameObject.SetActive(false);

    }
    public void goodChoice()
    {
        goodTalk.gameObject.SetActive(false);
        badTalk.gameObject.SetActive(false);
        talkButton.gameObject.SetActive(false);
        moveButton.gameObject.SetActive(true);
    }
    public void badChoice()
    {
        goodTalk.gameObject.SetActive(false);
        badTalk.gameObject.SetActive(false);
        talkButton.gameObject.SetActive(false);
        moveButton.gameObject.SetActive(true);
    }
}
