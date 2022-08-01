using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGamePopupSystem : MonoBehaviour
{
    public GameObject popup;
    public GameObject panel;
    public Text txt;
    public GameObject houseBtn;
    public GameObject lobbyBtn;
    public GameObject AMBtn;
    public GameObject officeBtn;

    public string SceneName;

    // Start is called before the first frame update
    void Start()
    {
        SceneName = SceneManager.GetActiveScene().name;
    }

    void SetPopup()
    {
        if (SceneName.Equals("House"))
        {
            txt.text = "어디로 이동하시겠습니까?";
            lobbyBtn.SetActive(true);
            AMBtn.SetActive(true);
        }
        else if (SceneName.Equals("AM"))
        {
            txt.text = "어디로 이동하시겠습니까?";
            lobbyBtn.SetActive(true);
            houseBtn.SetActive(true);
        }
        else if (SceneName.Equals("Lobby"))
        {
            txt.text = "어디로 이동하시겠습니까?";
            officeBtn.SetActive(true);
            AMBtn.SetActive(true);
            houseBtn.SetActive(true);
        }
        else if (SceneName.Equals("Daily_schedule"))
        {
            txt.text = "\n로비로 이동합니다";
        }
    }

    public void OpenPopup()
    {
        popup.SetActive(true);
        SetPopup();
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

        officeBtn.SetActive(false);
        AMBtn.SetActive(false);
        houseBtn.SetActive(false);

        panel.SetActive(false);
        Debug.Log("PopupOff");
    }
}
