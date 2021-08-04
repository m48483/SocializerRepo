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

}
