using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change : MonoBehaviour
{

    // 폐기
    public void OfficeChange()
    {
        SceneManager.LoadScene("Office");
    }
    public void HouseChange()
    {
        SceneManager.LoadScene("House");
    }
    public void LobbyChange()
    {
        LoadingScene.LoadScene("Lobby");
       // SceneManager.LoadScene("Lobby "+a);
        
    }
    public void AMChange()
    {
        SceneManager.LoadScene("AM");
    }
    //


    public void ReportScene()
    {
        SceneManager.LoadScene("Report");
    }
}
