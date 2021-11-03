using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    MenuUI _notice;
    PopUpDebug _pudebug;
    MsgReceive _msgrcv;
    PauseMenu _menu;

    private bool MenuOn = false;
    private bool MenuOff = true;

    void Awake()
    {
        _notice = FindObjectOfType<MenuUI>();
        _pudebug = FindObjectOfType<PopUpDebug>();
        _msgrcv = FindObjectOfType<MsgReceive>();

       
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("TestNotice2");
        
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Title")
            Destroy(gameObject);
    }
}

//각 씬마다 필요한 팝업 창 계속해서 추가할 것.
//해당 팝업창 라이프 사이클 주석처리로 정리.
//연결은 나중에 적용
