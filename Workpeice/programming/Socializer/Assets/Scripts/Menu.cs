using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    NoticeUI _notice;
    private Button btn;

    private void Awake()
    {
        _notice = FindObjectOfType<NoticeUI>();
        if (SceneManager.GetActiveScene().name == "Prologue") //프롤로그의 메뉴 버튼 전용
        {
            btn = transform.Find("MenuButton").GetComponent<Button>();
            btn.interactable = true; // 버튼 클릭을 활성
        }
    }

    public void MenuOn()
    {
        btn.interactable = false; // 버튼 클릭을 비활성
        _notice.SelectSUB();
    }

    public void CancelButton()  //취소버튼
    {
        _notice.CancelButton();
        btn.interactable = true; // 버튼 클릭을 활성
    }
}

