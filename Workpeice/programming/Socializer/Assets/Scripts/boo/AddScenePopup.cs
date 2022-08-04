using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddScenePopup : MonoBehaviour
{
    public static AddScenePopup instance = null;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Popup_modify", LoadSceneMode.Additive);
        //if (instance == null)
        //{
        //    instance = this;
        //    SceneManager.LoadScene("Popup_modify", LoadSceneMode.Additive);
        //    sceneName = SceneManager.GetActiveScene().name;
        //}
        //else if (instance != this)
        //{
        //    Destroy(gameObject);
        //}
        //DontDestroyOnLoad(this);
    }
}
