using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionInstance : MonoBehaviour
{
    public void OnClickButton()
    {
        OptionPopupSystem.instance.OpenPopup(
            () =>
            {
                Debug.Log("OnClick Btn");
            });
    }
}
