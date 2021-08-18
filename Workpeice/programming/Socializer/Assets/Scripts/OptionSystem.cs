using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OptionSystem : MonoBehaviour
{
    public GameObject popup;
    Action onClickCancel;
    public static OptionSystem instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }

    public void OpenPopUp(Action onClickCancel)
    {
        this.onClickCancel = onClickCancel;
        popup.SetActive(true);
    }

    public void OnClickCancel()
    {
        if (onClickCancel != null)
        {
            onClickCancel();
        }
        ClosePopup();
    }
    void ClosePopup()
    {
        popup.SetActive(false);
    }
}
