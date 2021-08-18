using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpUI : MonoBehaviour
{
    public void OnClickMyButton()
    {
        PopupSystem.instance.OpenPopUp(
            () =>
            {
                Debug.Log("Yes");
            },
            () =>
            {
                Debug.Log("No");
            }
            );
    }
}
