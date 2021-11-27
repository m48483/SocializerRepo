using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyScript : MonoBehaviour
{
    public static DontDestroyScript instance = null;
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
