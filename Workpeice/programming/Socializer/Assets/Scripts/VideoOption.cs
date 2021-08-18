using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoOption : MonoBehaviour
{
    FullScreenMode screenMode;
    public Dropdown resolutionDropdown;
    public Toggle windowScreenBtn;
    List<Resolution> resolutions = new List<Resolution>();
    public int resolutionNum;

    void Start()
    {
        InitUI();
    }

    void InitUI()
    {
        for(int i = 0; i < Screen.resolutions.Length; i++)
        {
            if (Screen.resolutions[i].refreshRate == 60)
                resolutions.Add(Screen.resolutions[i]);
        }
        resolutionDropdown.options.Clear();

        int optionNum = 0;

        foreach(Resolution item in resolutions)
        {
            Dropdown.OptionData option = new Dropdown.OptionData();
            option.text = item.width + "x" + item.height + " " + item.refreshRate + "hz";
            resolutionDropdown.options.Add(option);

            if (item.width == Screen.width && item.height == Screen.height)
                resolutionDropdown.value = optionNum;
            optionNum++;
        }
        resolutionDropdown.RefreshShownValue();
        windowScreenBtn.isOn = Screen.fullScreenMode.Equals(FullScreenMode.Windowed) ? true : false;
    }

    public void DropboxOptionChange(int x)
    {
        resolutionNum = x;
    }
    public void WindowScreenBtn(bool isWindow)
    {
        screenMode = isWindow ? FullScreenMode.Windowed : FullScreenMode.FullScreenWindow;
    }
    public void OkBtnClick()
    {
        Screen.SetResolution(resolutions[resolutionNum].width,
            resolutions[resolutionNum].height,
            screenMode);
    }
}
