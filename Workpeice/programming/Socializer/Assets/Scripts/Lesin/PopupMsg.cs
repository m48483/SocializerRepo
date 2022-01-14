using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PopupMsg : MonoBehaviour
{
    PopupUI _notice1;
    PopUpDebug _pudebug;
    MsgReceive _msgrcv;
    PauseMenu _menu;
    public GameObject btn;
    
    
    public static bool MenuOn = false;
    public static bool MenuOff = true; //평소에 트루, 메세지 들어오면 false로 변경되고, 메뉴종료 함수 호출시 false로 변경과 함께 메세지 전달 

    //메뉴 버튼을 누르면 MenuOn이 true로

    public void PopupMenu()
    {
        MenuOn = true;
    }
    public void PopLobbyGo()
    {
        btn.SetActive(true);
        _notice1.SelectSUB(3, "로비로 이동합니다.");
        _notice1.LobbyButton();
    }
    public void PopLobbyNo()
    {
        btn.SetActive(true);
        _notice1.SelectSUB("일을 마치기 전에는\n이동할 수 없습니다.");
    }
    public void PopAmNo()
    {
        btn.SetActive(true);
        _notice1.SelectSUB("조건을 충족하지 못하여\n갈 수 없습니다.");
    }
    public void PopMoveGo()
    {
        if (SceneManager.GetActiveScene().name == "Office")
        {   //if문으로 일이 끝났나 체크
            Debug.Log("일과 종료 체크");
            PopLobbyGo();
        }
        else if (SceneManager.GetActiveScene().name == "Lobby 1")
        {
            _notice1.SelectSUB(0, "어디로 이동하시겠습니까?");
        }
        else if (SceneManager.GetActiveScene().name == "House 1")
        {
            _notice1.SelectSUB(1, "어디로 이동하시겠습니까?");
        }
        else if (SceneManager.GetActiveScene().name == "AM")
        {
            _notice1.SelectSUB(2, "어디로 이동하시겠습니까?");
        }
    }

    public void ClosePopup()
    {
        btn.SetActive(false);
        _notice1.Cancel();
    }

    void Awake()
    {
        _notice1 = FindObjectOfType<PopupUI>();
        _pudebug = FindObjectOfType<PopUpDebug>();
        _msgrcv = FindObjectOfType<MsgReceive>();
        _menu = FindObjectOfType<PauseMenu>();
        btn.SetActive(false);
    }

    void Update()
    {
        if (MenuOn == true) //메뉴를 키도록 하는 부분
        {
            MenuOn = false;
            _menu.MenuOn();
            MenuOff = false;
        }
        if (MenuOff == false) //메뉴가 끝났다는 뜻
        {
            MenuOff = true;
            //Main씬에 메세지 전달
        }
    }
}

//각 씬마다 필요한 팝업 창 계속해서 추가할 것.
//해당 팝업창 라이프 사이클 주석처리로 정리.
//연결은 나중에 적용
