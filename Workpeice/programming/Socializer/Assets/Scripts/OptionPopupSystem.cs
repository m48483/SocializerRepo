﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionPopupSystem : MonoBehaviour
{
    public GameObject popup;
    public static bool isOn = false;

    public static OptionPopupSystem instance { get; private set; }

    Action onClickBtn;

    private void Awake()
    {
        isOn = this;
        instance = this;
    }

    public void OpenPopup(Action onClickBtn)
    {
        this.onClickBtn = onClickBtn;
        popup.SetActive(true);
        isOn = true;
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
        Debug.Log("PopupOff");
    }
}
