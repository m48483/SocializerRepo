using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NoticeUI : MonoBehaviour
{
    public GameObject subbox;
    public Text subintext;
    public Animator subani;
    //코루틴 딜레이 2개 미리 선언
    private WaitForSeconds _UIDelay1 = new WaitForSeconds(2.0f);
    private WaitForSeconds _UIDelay2 = new WaitForSeconds(0.3f);

    private void Start()
    {
        subbox.SetActive(false); //알림창은 미리 비활성화
    }
    // 서브 메세지 >> string값을 매개변수로 받아와서 2초간 출력
    // 사용법 : _notice.SUB("문자열");
    public void SUB(string message)
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
}