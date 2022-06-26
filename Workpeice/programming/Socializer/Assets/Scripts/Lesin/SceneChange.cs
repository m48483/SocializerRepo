using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    Fadeout _fadeout;
   
    private void Awake()
    {
        _fadeout = FindObjectOfType<Fadeout>();
    }


    public void TitleChange()
    {
        SceneManager.LoadScene("Title");
    }
    public void PopupChange()
    {        
        SceneManager.LoadScene("Popup");
    }
    public void NameSenceChange()
    {
        SceneManager.LoadScene("Name");
    }
    public void TutoChange()
    {  
        SceneManager.LoadScene("Tutorial");
    }
    public void LobbyChange()
    {
        SceneManager.LoadScene("Variables");
        SceneManager.LoadScene("Lobby", LoadSceneMode.Additive);
        _fadeout.FadeIn();

    }    
    public void OfficeChange()
    {
        SceneManager.LoadScene("Variables");
        SceneManager.LoadScene("Office", LoadSceneMode.Additive);
        _fadeout.FadeIn();
    }
    public void HouseChange()
    {
        SceneManager.LoadScene("Variables");
        SceneManager.LoadScene("House", LoadSceneMode.Additive);
        _fadeout.FadeIn();
    }
    public void AmChange()
    {
        SceneManager.LoadScene("AM", LoadSceneMode.Additive);
        _fadeout.FadeIn();
    }

    public void Init_UIChange()
    {
        SceneManager.LoadScene("Init_UI");
    }

    public void Daily_scheduleChange()
    {
        SceneManager.LoadScene("Variables");
        SceneManager.LoadScene("Daily_schedule", LoadSceneMode.Additive);
        _fadeout.FadeIn();
    }

    //페이드아웃 후 체인지

    /*
    public void TitleFadeChange()
    {
        _fadeout.FadeOut();
        Invoke("TitleFadeChange", 2);
    }
    public void PopupFadeChange()
    {
         _fadeout.FadeOut();
        Invoke("PopupFadeChange", 2);
    }
    public void NameSenceFadeChange()
    {
        _fadeout.FadeOut();
        Invoke("NameFadeChange", 2);
    }
    public void TutoFadeChange()
    {
         _fadeout.FadeOut();
        Invoke("TutoFadeChange", 2);
    }
    public void Init_UiFadeChange()
    {
        SceneManager.LoadScene("Init_Ui");
    }*/

    public void Init_UIFadeChange()
    {
        _fadeout.FadeOut();
        Invoke("Init_UI", 2);
    }
    

    public void LobbyFadeChange()
    {
        _fadeout.FadeOut();
        Invoke("LobbyChange", 2);
    }

    public void OfficeFadeChange()
    {
        _fadeout.FadeOut();
        Invoke("OfficeChange", 2);
    }
    public void HouseFadeChange()
    {
        _fadeout.FadeOut();
        Invoke("HouseChange", 2);
    }
    public void AmFadeChange()
    {
        _fadeout.FadeOut();
        Invoke("AmChange", 2);
    }

}
