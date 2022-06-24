using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoadSceneAdditive();
    }

    private void LoadSceneAdditive()
    {
        SceneManager.LoadScene("Variables", LoadSceneMode.Additive);
    }
}
