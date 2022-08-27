using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Slider backVolume;   // Slider의 Value
    public Slider backVolume2;   // Slider의 Value
    public AudioSource audio;
    public AudioSource effect_audio;

    public float backVol = 1f; // 껐다 켰을 떄도 Slider의 값 유지
    public float backVol2 = 1f; // 껐다 켰을 떄도 Slider의 값 유지

    void Start()
    {
        backVol = PlayerPrefs.GetFloat("backvol", 1f);
        backVolume.value = backVol;
        audio.volume = backVolume.value;
        backVol2 = PlayerPrefs.GetFloat("backvol2", 1f);
        backVolume2.value = backVol2;
        effect_audio.volume = backVolume2.value;
    }

    void Update()
    {
        SoundSlider();        
    }

    public void SoundSlider()
    {
        audio.volume = backVolume.value;

        backVol = backVolume.value;
        PlayerPrefs.SetFloat("backvol", backVol);

        if (backVol == 0)
        {
            AudioListener.pause = true;
        }
        else
        {
            AudioListener.pause = false;
        }

        effect_audio.volume = backVolume2.value;

        backVol2 = backVolume2.value;
        PlayerPrefs.SetFloat("backvol2", backVol2);

        if (backVol2 == 0)
        {
            effect_audio.mute = true;
            //AudioListener.pause = true;
        }
        else
        {
            effect_audio.mute = false;
            //AudioListener.pause = false;
        }
    }
}
