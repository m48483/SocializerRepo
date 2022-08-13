using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoOption : MonoBehaviour
{
    public Dropdown dropdown;
    public int dropdownNum;
    FullScreenMode screenMode;
    static public Toggle windowedscreenBtn;

    public void DropboxOptionChange()
    {
        switch (dropdown.value)
        {
            case 0:
                Screen.SetResolution(1920, 1080, screenMode);
                break;
            case 1:
                Screen.SetResolution(1600, 900, screenMode);
                break;
            case 2:
                Screen.SetResolution(1280, 720, screenMode);
                break;
        }
        Debug.Log(dropdown.value);
        windowedscreenBtn.isOn = Screen.fullScreenMode.Equals(FullScreenMode.Windowed) ? false : true;
    }
    public void WindowedScreenBtn(bool isWIndowed)
    {
        screenMode = isWIndowed ? FullScreenMode.Windowed : FullScreenMode.FullScreenWindow;

        Screen.SetResolution(Screen.width, Screen.height, screenMode);
    }
}
