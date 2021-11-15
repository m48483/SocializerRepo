using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change : MonoBehaviour
{
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
        SceneManager.LoadScene("Lobby");
    }
    public void AMChange()
    {
        SceneManager.LoadScene("AM");
    }
}
