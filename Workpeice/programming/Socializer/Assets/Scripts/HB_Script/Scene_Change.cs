using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change : MonoBehaviour
{
    Random rand = new Random();

    public void OfficeChange()
    {
        SceneManager.LoadScene("Office");
    }
    public void HouseChange()
    {
        int a = Random.Range(1,6);
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
}
