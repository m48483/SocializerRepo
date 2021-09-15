using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance = null;
    OpenSliders openSliders;
    void Awake()
    {
        openSliders = GetComponent<OpenSliders>();

        if (instance != null)
        {
            Destroy(this.gameObject);
            Debug.Log(OpenSliders.isSliderOn);
            OptionPopupSystem.isOn = false;
        }

        instance = this;
        DontDestroyOnLoad(this);
    }
}
