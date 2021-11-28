using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterVolumeManager : AudioManager
{
    public AudioSource effectAudio;
    void Start()
    {
        // 뭔가 개별 슬라이더에선 제대로 안 먹는 느낌?? 보수공사 필요
    }
    private void Update()
    {
        effectAudio.volume = backVolume.value;
        base.SoundSlider();
    }
}
