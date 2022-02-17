using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fadeout : MonoBehaviour
{
    public GameObject subbox;
    public Animator subani;
    SceneChange _sceneChange;
    PauseMenu _menu;
    PopUpDebug _pudedug;

    //코루틴 딜레이 2개 미리 선언
    private WaitForSecondsRealtime _UIDelay1 = new WaitForSecondsRealtime(2.0f);
    private WaitForSecondsRealtime _UIDelay2 = new WaitForSecondsRealtime(0.3f);
    
    void Start()
    {
        subbox.SetActive(false);
    }

    public void FadeIn()
    {
        StopAllCoroutines();
        StartCoroutine(InDelay());
    }

    public void FadeOut()
    {
        subbox.SetActive(false);
        StopAllCoroutines();
        StartCoroutine(OutDelay());
    }

    IEnumerator InDelay()
    {
        Debug.Log("페이드 인");
        subani.SetBool("isOn", false);
        yield return _UIDelay1;
        subbox.SetActive(false);
    }

    IEnumerator OutDelay()
    {
        Debug.Log("페이드 아웃");
        subbox.SetActive(true);
        subani.SetBool("isOn", true);
        yield return _UIDelay1;
    }

}
