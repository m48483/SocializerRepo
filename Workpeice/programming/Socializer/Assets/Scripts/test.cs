using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    NoticeUI _notice;

    private void Awake()
    {
        _notice = FindObjectOfType<NoticeUI>();
    }

    public void Test()
    {
        _notice.SelectSUB("하나만 선택해");
    }

}
