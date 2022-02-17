using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Init_UI : MonoBehaviour
{
    MenuUI _notice;
    PopUpDebug _pudebug;
    MsgReceive _msgrcv;
    PauseMenu _menu;
    PopupMsg _popupmsg;

    void Awake()
    {
        _notice = FindObjectOfType<MenuUI>();
        _pudebug = FindObjectOfType<PopUpDebug>();
        _msgrcv = FindObjectOfType<MsgReceive>();
        _menu = FindObjectOfType<PauseMenu>();
        _popupmsg = FindObjectOfType<PopupMsg>();


        DontDestroyOnLoad(gameObject);
        _popupmsg.btn.SetActive(false);
        //if문으로 하여금 다음 로드 씬을 불러오게 해야됨 (세이브 로드 구현 이후 적용하기)
        SceneManager.LoadScene("Daily_schedule");
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Title")
            Destroy(gameObject);
    }
}
