using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionPopupSystem : MonoBehaviour
{
    public GameObject popup;
    public GameObject btn_popup;
    public GameObject panel;
    public Button btn;
    public static bool isOn = false;

    //public static OptionPopupSystem instance { get; private set; }

    Action onClickBtn;

    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "name")
        {
            btn_popup.SetActive(false);
        }
        else
        {
            btn_popup.SetActive(true);
        }
    }
    private void Awake()
    {
        isOn = this;
        //instance = this;
    }

    public void OpenPopup()//Action onClickBtn)
    {
        //this.onClickBtn = onClickBtn;
        popup.SetActive(true);
        isOn = true;
        panel.SetActive(true);
        Debug.Log("PopupOn");
    }

    public void OnClickBtn()
    {
        ClosePopUP();
    }

    void ClosePopUP()
    {
        popup.SetActive(false);
        isOn = false;
        panel.SetActive(false);
        Debug.Log("PopupOff");
    }
}
