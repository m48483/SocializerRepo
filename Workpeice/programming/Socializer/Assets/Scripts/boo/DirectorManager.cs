using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectorManager : MonoBehaviour
{
    public AudioSource[] audioSource;
    public GameObject[] bg;

    public void BGM_Stop()
    {
        audioSource[0].Stop();
    }
    public void Ending5_BGM_Play()
    {
        audioSource[0].Play();
    }
    public void Ending6_BGM_Play()
    {
        audioSource[1].Play();
    }
    public void lobby_load()
    {
        bg[0].SetActive(true);
    }
    public void lobby_unload()
    {
        bg[0].SetActive(false);
    }
    public void office_load()
    {
        bg[1].SetActive(true);
    }
    public void office_unload()
    {
        bg[1].SetActive(false);
    }
}
