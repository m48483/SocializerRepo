using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSystem : MonoBehaviour
{
    public GameObject popup;
    public GameObject btn_popup;
    public GameObject panel;
    // Start is called before the first frame update

    public void OpenPopup()//Action onClickBtn)
    {
        //this.onClickBtn = onClickBtn;
        popup.SetActive(true);
        panel.SetActive(true);
        Debug.Log("PopupOn");
    }

    public void OnClickBtn()
    {
        ClosePopUP();
    }

    void ClosePopUP()
    {
        popup.SetActive(false);
        panel.SetActive(false);
        Debug.Log("PopupOff");
    }
}
