using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NoticeUI : MonoBehaviour
{
    public GameObject subbox;
    public Text subintext;
    public Animator subani;
    public Button YButton;
    public Button NButton;

    //코루틴 딜레이 2개 미리 선언
    private WaitForSeconds _UIDelay1 = new WaitForSeconds(2.0f);
    private WaitForSeconds _UIDelay2 = new WaitForSeconds(0.3f);

    private void Start()
    {
        subbox.SetActive(false); //알림창은 미리 비활성화
    }
    // 서브 메세지 >> string값을 매개변수로 받아와서 2초간 출력
    // 사용법 : _notice.SUB("문자열"); notice는 참조된 변수 이름
   
    //선택지 없는 팝업
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

    //선택지 있는 팝업
    public void SelectSUB(string message) 
    {
        subintext.text = message;
        subbox.SetActive(false);
        StopAllCoroutines();
        StartCoroutine(SelectDelay());
    }

    IEnumerator SelectDelay() //선택지 없은 경우
    {
        subbox.SetActive(true);
        subani.SetBool("isOn", true);        
        yield return _UIDelay1;
    }

    public void YesButton()
    {
        subani.SetBool("YesNo", true);
        subani.SetTrigger("Select");
        StartCoroutine(SelectOut());
    }

    public void NoButton()
    {
        subani.SetBool("YesNo", false);
        subani.SetTrigger("Select");
        StartCoroutine(SelectOut());
    }

    IEnumerator SelectOut() //선택지 없은 경우
    {
        subani.SetBool("isOn", false);
        yield return _UIDelay2;
        subbox.SetActive(false);
    }





}