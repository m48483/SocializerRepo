using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionUI : MonoBehaviour
{
    public void OnClickMyButton()
    {
        OptionSystem.instance.OpenPopUp(
            () =>
            {
                Debug.Log("No");
            }
            );
    }
}
