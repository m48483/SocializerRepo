using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenSliders : MonoBehaviour
{
    public GameObject canvas;
    public static bool isSliderOn;

    void Start()
    {
        OptionPopupSystem.isOn = false;
    }
    void Update()
    {
        OpenMySliders();
    }

    public void OpenMySliders()
    {
        isSliderOn = OptionPopupSystem.isOn;
        if (isSliderOn == true)
        {
            canvas.SetActive(true);
        }
        else
        {
            canvas.SetActive(false);
        }
    }
}
