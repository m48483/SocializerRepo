using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class PopupUI : MonoBehaviour
{
    public GameObject subbox;
    public Text subintext;
    public Animator subani;
    public GameObject am_button;
    public GameObject Lobby_button;
    public GameObject House_button;
    public GameObject Lobbygo_button;
    public GameObject move_button;
    public GameObject menu_button;


    SceneChange _sceneChange;
    PauseMenu _menu;
    PopUpDebug _pudedug;
    Fadeout _fadeout;

    //코루틴 딜레이 2개 미리 선언
    private WaitForSecondsRealtime _UIDelay1 = new WaitForSecondsRealtime(2.0f);
    private WaitForSecondsRealtime _UIDelay2 = new WaitForSecondsRealtime(0.3f);

    private void Awake()
    {
        _sceneChange = FindObjectOfType<SceneChange>();
        _menu = FindObjectOfType<PauseMenu>();
        _pudedug = FindObjectOfType<PopUpDebug>();
    }
    private void Start()
    {
        subbox.SetActive(false); //알림창은 미리 비활성화
    }
    // 서브 메세지 >> string값을 매개변수로 받아와서 2초간 출력
    // 사용법 : _notice.SUB("문자열"); notice는 참조된 변수 이름
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Report")
        {
            am_button.SetActive(false);
            Lobby_button.SetActive(false);
            House_button.SetActive(false);
            Lobbygo_button.SetActive(false);
            move_button.SetActive(false);
            menu_button.SetActive(false);
        }
    }
    //바로 사라지는 팝업
    public void SUB(string message) //
    {
        subintext.text = message;
        subbox.SetActive(false);
        StopAllCoroutines();
        StartCoroutine(SUBDelay());
    }

    IEnumerator SUBDelay()
    {
        subbox.SetActive(true);
        subani.SetBool("isOn", true);
        yield return _UIDelay1;
        subani.SetBool("isOn", false);
        yield return _UIDelay2;
        subbox.SetActive(false);
    }

    //상호작용 이후 사라지는 팝업
    public void SelectSUB(string message)
    {
        subintext.text = message;
        subbox.SetActive(false);
        StopAllCoroutines();
        StartCoroutine(SelectDelay());
    }
    public void SelectSUB()
    {
        subbox.SetActive(false);
        StopAllCoroutines();
        StartCoroutine(SelectDelay());
    }
    //이동 팝업
    public void SelectSUB(int place, string message)
    {
        subintext.text = message;
        switch (place)
        {
            case 0://로비
                Lobby_button.SetActive(true);
                House_button.SetActive(false);
                am_button.SetActive(false);
                Lobbygo_button.SetActive(false);
                move_button.SetActive(true);
                break;
            case 1://집
                Lobby_button.SetActive(false);
                House_button.SetActive(true);
                am_button.SetActive(false);
                break;
            case 2://am
                Lobby_button.SetActive(false);
                House_button.SetActive(false);
                am_button.SetActive(true);
                break;
            case 3://사무실
                Lobby_button.SetActive(false);
                House_button.SetActive(false);
                am_button.SetActive(false);
                break;
        }
        subbox.SetActive(false);
        StopAllCoroutines();
        StartCoroutine(SelectDelay());
    }
    IEnumerator SelectDelay() //선택지 있는 경우
    {
        subbox.SetActive(true);
        subani.SetBool("isOn", true);
        yield return _UIDelay1;
    }

    public void Cancel() //취소 버튼
    {
        StartCoroutine(SelectOut());
    }

    IEnumerator SelectOut() //선택지 있는 경우
    {
        subani.SetBool("isOn", false);
        yield return _UIDelay2;
        subbox.SetActive(false);
    }
    public void textbutton() //오피스 버튼
    {
        StartCoroutine(SelectOut());
        _sceneChange.OfficeFadeChange();
        SetButton();
    }
    public void OfficeButton() //오피스 버튼
    {
        StartCoroutine(SelectOut());
        _sceneChange.OfficeFadeChange();
        SetButton();
        Lobbygo_button.SetActive(true);
        move_button.SetActive(false);
    }
    public void AmButton() //AM 버튼
    {
        StartCoroutine(SelectOut());
        _sceneChange.AmFadeChange();
        SetButton();
    }
    public void HouseButton() //집 버튼
    {
        StartCoroutine(SelectOut());
        _sceneChange.HouseFadeChange();
        SetButton();
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
        SetButton();
        Lobbygo_button.SetActive(false);
        move_button.SetActive(true);

    }
    public void SetButton()
    {
        Lobby_button.SetActive(false);
        House_button.SetActive(false);
        am_button.SetActive(false);
    }
}