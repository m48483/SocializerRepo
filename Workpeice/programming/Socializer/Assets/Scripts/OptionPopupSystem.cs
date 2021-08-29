using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionPopupSystem : MonoBehaviour
{
    public GameObject popup;

    public static OptionPopupSystem instance { get; private set; }

    Action onClickBtn;

    private void Awake()
    {
        instance = this;
    }

    public void OpenPopup(Action onClickBtn)
    {
        this.onClickBtn = onClickBtn;
        popup.SetActive(true);
    }

    public void OnClickBtn()
    {
        ClosePopUP();
    }

    void ClosePopUP()
    {
        popup.SetActive(false);
    }
}
