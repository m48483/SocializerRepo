using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DontDestroyScript : MonoBehaviour
{
    public static DontDestroyScript instance = null;
    OpenSliders openSliders;
    public GameObject btn;
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
            btn.SetActive(false);
            if (SceneManager.GetActiveScene().name != "name")
                Destroy(gameObject);
        }
        else
        {
            btn.SetActive(true);
        }
    }
}
