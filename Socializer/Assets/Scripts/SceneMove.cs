using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public void TitleScene()
    {
        SceneManager.LoadScene("Title");
    }
    public void NewCharacterScene()
    {
        SceneManager.LoadScene("NewCharacter");
    }

    public void AMscene()
    {
        SceneManager.LoadScene("AM");
    }

    public void HomeScene()
    {
        SceneManager.LoadScene("Home");
    }
    public void OfficeScene()
    {
        SceneManager.LoadScene("Office");
    }
    public void LobbyScene()
    {
        SceneManager.LoadScene("Lobby");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
