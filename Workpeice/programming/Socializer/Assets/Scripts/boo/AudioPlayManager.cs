using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AudioPlayManager : MonoBehaviour
{
    public AudioSource[] audioSource;
    public string SceneName;
    public float Heather_reliability;
    public float Frances_conversation;
    public int Day;

    public Slider backVolume;   // Slider의 Value

    public float backVol = 1f; // 껐다 켰을 떄도 Slider의 값 유지

    // Start is called before the first frame update
    void Start()
    {
        Heather_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability");
        Frances_conversation = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability");
        Day = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Day");
        SceneName = SceneManager.GetActiveScene().name;

        backVol = PlayerPrefs.GetFloat("backvol", 1f);
        backVolume.value = backVol;
        for (int i = 0; i < audioSource.Length; i++)
        {
            audioSource[i].volume = backVolume.value;
        }

        Debug.Log(SceneName);
        BGMSet();
    }
    public void BGMSet()
    {
        if (SceneName.Equals("House"))
        {
            if (Heather_reliability > 60)
            {
                audioSource[0].Play();
            }
            else
            {
                audioSource[1].Play();
            }
        }
        else if (SceneName.Equals("Daily_schedule"))
        {
            if (Day >= 57 && Day < 61)
            {
                audioSource[3].Play();
            }
            else
            {
                audioSource[2].Play();
            }
        }
        else if (SceneName.Equals("Lobby"))
        {
            if (Day >= 57 && Day < 61)
            {
                audioSource[3].Play();
            }
            else
            {
                audioSource[2].Play();
            }
        }
        else if (SceneName.Equals("Office"))
        {
            if (Day >= 57 && Day < 61)
            {
                audioSource[3].Play();
            }
            else
            {
                audioSource[2].Play();
            }
        }
        else if (SceneName.Equals("AM"))
        {
            if (Frances_conversation < 80)
            {
                audioSource[4].Play();
            }
            else if (Frances_conversation >= 80)
            {
                audioSource[5].Play();
            }
        }
        else if (SceneName.Equals("Tutorial"))
        {
            audioSource[6].Play();
        }
        else if (SceneName.Contains("Ending"))
        {
            if(SceneName.Equals("Ending5"))
                audioSource[7].Play();
            else if(SceneName.Equals("Ending6"))
                audioSource[8].Play();
            else
                audioSource[6].Play();
        }
    }

    void Update()
    {
        SoundSlider();
    }

    public void SoundSlider()
    {
        for (int i = 0; i < audioSource.Length; i++)
        {
            audioSource[i].volume = backVolume.value;
        }

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
    }
}
