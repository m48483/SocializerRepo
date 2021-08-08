using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    NoticeUI _notice;

    private void Awake()
    {
        _notice = FindObjectOfType<NoticeUI>();
    }

    public void MenuOn()
    {
        _notice.SelectSUB();
    }

    public void CancelButton()  //취소버튼
    {
        _notice.subbox.SetActive(false); //알림창은 미리 비활성화
    }
}
