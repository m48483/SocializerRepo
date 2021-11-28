using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
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
    
}
