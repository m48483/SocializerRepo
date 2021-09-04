using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class testprint1 : MonoBehaviour
{
    public GameObject ButtonName;
    public int Testnumber = 1;

    public void Awake()
    {
        ButtonName = GameObject.Find("testButton");
    }

    public void Clicked()
    {
        Debug.Log(ButtonName.name + " 버튼 클릭");
        Debug.Log("메시지 전달 확인");
    }
}
