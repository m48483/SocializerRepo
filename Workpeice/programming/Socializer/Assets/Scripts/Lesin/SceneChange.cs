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
    public void Init_UiChange()
    {
        SceneManager.LoadScene("Init_Ui");
    }
    public void LobbyChange()
    {
        _fadeout.FadeOut();
        //SceneManager.LoadScene("Test_Lobby");
        _fadeout.FadeIn();
    }

    public void OfficeChange()
    {
        _fadeout.FadeOut();
        SceneManager.LoadScene("Office");
        _fadeout.FadeIn();
    }
    public void HouseChange()
    {
        _fadeout.FadeOut();
        SceneManager.LoadScene("House");
        _fadeout.FadeIn();
    }
    public void AmChange()
    {
        _fadeout.FadeOut();
        SceneManager.LoadScene("AM");
        _fadeout.FadeIn();
    }

}
