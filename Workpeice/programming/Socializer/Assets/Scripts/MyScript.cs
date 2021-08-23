using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyScript : MonoBehaviour
{
    public void OnClickButton()
    {
        PopupSystem.instance.OpenPopup(
            () =>
            {
                Debug.Log("OnClick Yes");
            },
            () =>
            {
                Debug.Log("Onclick No");
            });
    }
}
