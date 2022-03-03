using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NoticeUI : MonoBehaviour
{
    [Header("SubNotice")]
    public GameObject subbox;
    public GameObject btn;
    public Text subintext1;
    public Text subintext2;
    public Text subintext3;
    public Animator subani;
    public int f = 1;
    // 코루틴 딜레이
    private WaitForSeconds _UIDelay1 = new WaitForSeconds(0.3f);
    private WaitForSeconds _UIDelay2 = new WaitForSeconds(0.3f);

    void Start()
    {
        subbox.SetActive(false);
    }

    // 서브 메세지 >> string 값을 매개 변수로 받아와서 2초간 출력
    // 사용법 : _notice.SUB("문자열");
    public void SUB(string message1, string message2, string message3)
    {
        subintext1.text = message1;
        subintext2.text = message2;
        subintext3.text = message3;
        subbox.SetActive(false);
        StopAllCoroutines();
        StartCoroutine(SUBDelay());
        f *= -1;
    }

    // 반복 되지 않게 하기 위해서 딜레이 설정
    IEnumerator SUBDelay()
    {
        if (f == 1)
        {
            subbox.SetActive(true);
            btn.SetActive(true);
            subani.SetBool("isOn", true);
            yield return _UIDelay1;
        }
        
        else if (f == -1)
        {
            subani.SetBool("isOn", false);
            btn.SetActive(false);
            yield return _UIDelay2;
            subbox.SetActive(false);
        }
    }
}