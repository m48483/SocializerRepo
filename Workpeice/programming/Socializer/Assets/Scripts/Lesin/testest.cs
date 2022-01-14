using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testest : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadingSceneManager.LoadScene("Scene2");
        }
    }

}
