using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fadeout : MonoBehaviour
{
    public GameObject subbox;
    public Animator subani;
    SceneChange _sceneChange;
    PauseMenu _menu;
    PopUpDebug _pudebug;

    //코루틴 딜레이 2개 미리 선언
    private WaitForSecondsRealtime _UIDelay1 = new WaitForSecondsRealtime(2.0f);

    private void Awake()
    {
        _sceneChange = FindObjectOfType<SceneChange>();
        _menu = FindObjectOfType<PauseMenu>();
        _pudebug = FindObjectOfType<PopUpDebug>();
    }

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
        subbox.SetActive(true);
        Debug.Log("페이드 인");
        subani.SetBool("isOn", false);
        yield return _UIDelay1;
        Invoke("safc", 2);
    }

    IEnumerator OutDelay()
    {
        Debug.Log("페이드 아웃");
        subbox.SetActive(true);
        subani.SetBool("isOn", true);
        yield return _UIDelay1;
    }
    public void safc()
    {
        subbox.SetActive(false);
    }

}
