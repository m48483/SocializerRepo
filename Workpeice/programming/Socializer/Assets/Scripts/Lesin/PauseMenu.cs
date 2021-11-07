using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    MenuUI _notice;
    PopUpDebug _pudebug;
    MsgReceive _msgrcv;
    public Button btn;


    private void Awake()
    {
        _notice = FindObjectOfType<MenuUI>();
        _pudebug = FindObjectOfType<PopUpDebug>();
        _msgrcv = FindObjectOfType<MsgReceive>();

        if (SceneManager.GetActiveScene().name == "Popup" || SceneManager.GetActiveScene().name == "Notice") //프롤로그의 메뉴 버튼 전용
        {
            btn = transform.Find("MenuButton").GetComponent<Button>();
            btn.interactable = true; // 버튼 클릭을 활성
        }
    }

    public void MenuOn()
    {
        btn.interactable = false; // 버튼 클릭을 비활성
        _notice.SelectSUB();
        _pudebug.MenuTActiveLog();
        _msgrcv.PauseMenuOn();
    }

    public void MenuOff()  //취소버튼
    {
        _msgrcv.PauseMenuOff();
        _notice.Cancel();
        btn.interactable = true; // 버튼 클릭을 활성
        _pudebug.MenuFActiveLog();
    }
}

