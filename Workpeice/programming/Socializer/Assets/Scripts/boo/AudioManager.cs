using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance = null;
    OpenSliders openSliders;
    void Awake()
    {
        openSliders = GetComponent<OpenSliders>();

        if (instance == null)
            instance = this;
        else if (instance != this)
        {
            Destroy(gameObject);
            Debug.Log(OpenSliders.isSliderOn);
            OptionPopupSystem.isOn = false;
        }
        DontDestroyOnLoad(this);
        Debug.Log(SceneManager.GetActiveScene().name);


        //if (SceneManager.GetActiveScene().buildIndex == 0
        //    || SceneManager.GetActiveScene().buildIndex == 2)
        //{
        //    //SceneManager.GetActiveScene().name == "Title"
        //    if (instance != null)
        //    {
        //        Destroy(this.gameObject);
        //        Debug.Log(OpenSliders.isSliderOn);
        //        OptionPopupSystem.isOn = false;
        //    }
        //    else
        //    {
        //        instance = this;
        //        DontDestroyOnLoad(this);
        //        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        //    }
        //}
        //else
        //{
        //    GameObject.Destroy(this);
        //    //Destroy(this.gameObject);
        //}

        //if (instance != null)
        //{
        //    Destroy(this.gameObject);
        //    Debug.Log(OpenSliders.isSliderOn);
        //    OptionPopupSystem.isOn = false;
        //}
        //else
        //{
        //    instance = this;
        //    DontDestroyOnLoad(this);
        //}
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name != "Title")
        {
            if (SceneManager.GetActiveScene().name != "name")
                Destroy(gameObject);
        }
    }
}
