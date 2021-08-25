using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupInstance : MonoBehaviour
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
