using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoticeMsg : MonoBehaviour
{
    MenuUI _notice;

    private void Awake()
    {
        _notice = FindObjectOfType<MenuUI>();
    }

    public void NotName()
    {
       _notice.SUB("이름을 작성해주세요.");
    }

    public void ExMessage()
    {
        _notice.SUB("이름에 공백 혹은 \n특수문자가\n사용되었습니다.");
    }

}
