using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PopupSystem : MonoBehaviour
{
    public GameObject popup;
    Action onClickYes, onClickNo;

    public static PopupSystem instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }

    public void OpenPopUp(Action onClickYes, Action onClickNo)
    {
        //txtContent.text = content;
        this.onClickYes = onClickYes;
        this.onClickNo = onClickNo;
        popup.SetActive(true);
    }

    public void OnClickYes()
    {
        if (onClickYes != null)
        {
            onClickYes();
        }
        SceneManager.LoadScene("name");
    }
    public void OnClickNo()
    {
        if (onClickNo != null)
        {
            onClickNo();
        }
        ClosePopup();
    }

    void ClosePopup()
    {
        popup.SetActive(false);
    }
}
