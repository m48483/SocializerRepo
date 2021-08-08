﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    public Slider backVolume;   // Slider의 Value
    public AudioSource audio;

    private float backVol = 1f; // 껐다 켰을 떄도 Slider의 값 유지

    void Start()
    {
        backVol = PlayerPrefs.GetFloat("backvol", 1f);
        backVolume.value = backVol;
        audio.volume = backVolume.value;
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
    }
}
