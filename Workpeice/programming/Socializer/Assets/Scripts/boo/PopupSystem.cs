using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PopupSystem : MonoBehaviour
{
    public GameObject popup;

    public static PopupSystem instance { get; private set; }

    public Text txtContent;
    Action onClickYes, onClickNo;

    private void Awake()
    {
        instance = this;
    }

    public void OpenPopup(
        Action onClickYes,
        Action onClickNo)
    {
        this.onClickYes = onClickYes;
        this.onClickNo = onClickNo;
        popup.SetActive(true);
    }

    public void OnClickYes()
    {
        if (onClickYes != null)
        {
            SceneManager.LoadScene("name");
            //SceneManager.LoadScene("VarEx");
        }

        ClosePopUP();
    }

    public void OnClickNo()
    {
        if (onClickNo != null)
        {
            onClickNo();
        }

        ClosePopUP();
    }

    void ClosePopUP()
    {
        popup.SetActive(false);
    }
}
