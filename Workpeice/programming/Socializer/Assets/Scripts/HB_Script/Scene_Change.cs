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
        SceneManager.LoadScene("House "+a);
        Debug.Log("House " + a + "호출");
    }
    public void LobbyChange()
    {
        int a = Random.Range(1, 5);       
        SceneManager.LoadScene("Lobby "+a);
        Debug.Log("Lobby " + a + "호출");
    }
    public void AMChange()
    {
        SceneManager.LoadScene("AM");
    }
}
