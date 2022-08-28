using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class BGSoundChange : MonoBehaviour
{
    public AudioClip[] audioClip;
    public AudioSource[] audioSource;


    // 배경 : 1. 사무실 2. 사무실 호감도 변경 수정본_1_1 3. 로비 4. 검은배경
    // 사운드 : 1. 중앙정보원 테마 2_2 2. 엔딩 테마 1 3. 엔딩 테마 2
    // 효과음 : 1. 노이즈 효과음 2_3 2. 타이핑 소리 1_3

    public void SoundEffect1()
    {
        GameObject.Find("SayDialog").GetComponent<WriterAudio>().soundEffect = audioClip[0];
    }
    public void SoundEffect2()
    {
        GameObject.Find("SayDialog").GetComponent<WriterAudio>().soundEffect = audioClip[1];
    }
    public void BG1()
    {
        GameObject.Find("BGSound").transform.Find("BG").transform.Find("사무실").gameObject.SetActive(true);
        GameObject.Find("BGSound").transform.Find("BG").transform.Find("사무실 호감도 변경 수정본_1_1").gameObject.SetActive(false);
        GameObject.Find("BGSound").transform.Find("BG").transform.Find("로비").gameObject.SetActive(false);
        GameObject.Find("BGSound").transform.Find("BG").transform.Find("검은배경").gameObject.SetActive(false);
    }
    public void BG2()
    {
        GameObject.Find("BGSound").transform.Find("BG").transform.Find("사무실").gameObject.SetActive(false);
        GameObject.Find("BGSound").transform.Find("BG").transform.Find("사무실 호감도 변경 수정본_1_1").gameObject.SetActive(true);
        GameObject.Find("BGSound").transform.Find("BG").transform.Find("로비").gameObject.SetActive(false);
        GameObject.Find("BGSound").transform.Find("BG").transform.Find("검은배경").gameObject.SetActive(false);
    }
    public void BG3()
    {
        GameObject.Find("BGSound").transform.Find("BG").transform.Find("사무실").gameObject.SetActive(false);
        GameObject.Find("BGSound").transform.Find("BG").transform.Find("사무실 호감도 변경 수정본_1_1").gameObject.SetActive(false);
        GameObject.Find("BGSound").transform.Find("BG").transform.Find("로비").gameObject.SetActive(true);
        GameObject.Find("BGSound").transform.Find("BG").transform.Find("검은배경").gameObject.SetActive(false);
    }
    public void BG4()
    {
        GameObject.Find("BGSound").transform.Find("BG").transform.Find("사무실").gameObject.SetActive(false);
        GameObject.Find("BGSound").transform.Find("BG").transform.Find("사무실 호감도 변경 수정본_1_1").gameObject.SetActive(false);
        GameObject.Find("BGSound").transform.Find("BG").transform.Find("로비").gameObject.SetActive(false);
        GameObject.Find("BGSound").transform.Find("BG").transform.Find("검은배경").gameObject.SetActive(true);
    }
}
