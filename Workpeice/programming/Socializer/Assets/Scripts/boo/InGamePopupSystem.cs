using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGamePopupSystem : MonoBehaviour
{
    public GameObject popup;
    public GameObject panel;
    public GameObject btnMove;
    public GameObject btnDont;
    
    public GameObject btn;
    public GameObject txtDay;

    public Text txt;
    public GameObject houseBtn;
    public GameObject lobbyBtn;
    public GameObject AMBtn;
    public GameObject officeBtn;
    bool setBtn;

    public Animator subani;

    public string SceneName;
    SceneChange _sceneChange;

    //코루틴 딜레이 2개 미리 선언
    private WaitForSecondsRealtime _UIDelay1 = new WaitForSecondsRealtime(2.0f);
    private WaitForSecondsRealtime _UIDelay2 = new WaitForSecondsRealtime(0.3f);

    // Start is called before the first frame update
    void Start()
    {
        SceneName = SceneManager.GetActiveScene().name;
        _sceneChange = FindObjectOfType<SceneChange>();

        if (SceneName.Equals("Tutorial"))
        {
            btn.SetActive(false);
            txtDay.SetActive(false);
        }
    }

    void SetPopup()
    {
        if (SceneName.Equals("House"))
        {
            SelectSUB("어디로 이동하시겠습니까?");
            lobbyBtn.SetActive(true);
            AMBtn.SetActive(true);
        }
        else if (SceneName.Equals("AM"))
        {
            SelectSUB("어디로 이동하시겠습니까?");
            lobbyBtn.SetActive(true);
            houseBtn.SetActive(true);
        }
        else if (SceneName.Equals("Lobby"))
        {
            SelectSUB("어디로 이동하시겠습니까?");
            officeBtn.SetActive(true);
            AMBtn.SetActive(true);
            houseBtn.SetActive(true);
        }
        else if (SceneName.Equals("Daily_schedule"))
        {
            if (GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Daily_schedule"))
            {
                SelectSUB("\n로비로 이동합니다");
                btnMove.SetActive(true);
            }
            else
            {
                SelectSUB("일을 마치기 전에는\n이동할 수 없습니다.");
                btnDont.SetActive(true);
            }
        }
    }

    public void OpenPopup()
    {
        if (setBtn)
        {
            OnClickBtn();
            setBtn = false;
        }
        else
        {
            popup.SetActive(true);
            SetPopup();
            panel.SetActive(true);
            Debug.Log("PopupOn");
            setBtn = true;
        }
    }

    public void OnClickBtn()
    {
        ClosePopUP();
        panel.SetActive(false);
    }

    void ClosePopUP()
    {
        popup.SetActive(false);

        officeBtn.SetActive(false);
        AMBtn.SetActive(false);
        houseBtn.SetActive(false);
        btnDont.SetActive(false);
        Debug.Log("PopupOff");
    }

    //바로 사라지는 팝업
    public void SUB() //
    {
        popup.SetActive(false);
        StopAllCoroutines();
        StartCoroutine(SUBDelay());
    }

    IEnumerator SUBDelay()
    {
        popup.SetActive(true);
        subani.SetBool("isOn", true);
        yield return _UIDelay1;
        subani.SetBool("isOn", false);
        yield return _UIDelay2;
        popup.SetActive(false);
        btnDont.SetActive(false);
        panel.SetActive(false);
    }

    public void SelectSUB(string message)
    {
        txt.text = message;
        popup.SetActive(false);
        StopAllCoroutines();
        StartCoroutine(SelectDelay());
    }
    public void SelectSUB()
    {
        popup.SetActive(false);
        StopAllCoroutines();
        StartCoroutine(SelectDelay());
    }
    IEnumerator SelectDelay() //선택지 있는 경우
    {
        popup.SetActive(true);
        subani.SetBool("isOn", true);
        yield return _UIDelay1;
    }

    public void SelectSUB(int place, string message)
    {
        txt.text = message;
        popup.SetActive(false);
        StopAllCoroutines();
        StartCoroutine(SelectDelay());
    }

    public void Cancel() //취소 버튼
    {
        StartCoroutine(SelectOut());
    }

    IEnumerator SelectOut() //선택지 있는 경우
    {
        subani.SetBool("isOn", false);
        yield return _UIDelay2;
        popup.SetActive(false);
    }

    public void OfficeButton() //오피스 버튼
    {
        StartCoroutine(SelectOut());
        _sceneChange.OfficeFadeChange();;
    }
    public void AmButton() //AM 버튼
    {
        StartCoroutine(SelectOut());
        _sceneChange.AmFadeChange();
    }
    public void HouseButton() //집 버튼
    {
        StartCoroutine(SelectOut());
        _sceneChange.HouseFadeChange();
    }
    public void LobbyButton() //로비 버튼
    {
        if (SceneManager.GetActiveScene().name == "Daily_schedule")
        {
            StopAllCoroutines();
        }
        else
        {
            StartCoroutine(SelectOut());
        }
        _sceneChange.LobbyFadeChange();
    }
}
