using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class testprint : MonoBehaviour
{
    public GameObject ButtonName;
    public testprint1 _test1;

    public void Clicked()
    {
        ButtonName = EventSystem.current.currentSelectedGameObject;
        Debug.Log(ButtonName.name+" 버튼 클릭");
        _test1 = FindObjectOfType<testprint1>();
        _test1.Clicked();
        _test1.Testnumber = 2;
        Debug.Log(_test1.Testnumber);
    }
}




