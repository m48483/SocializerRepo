using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance = null;
    void Awake()
    {
        if (instance != null)
            Destroy(this.gameObject);

        instance = this;
        DontDestroyOnLoad(this);
    }
}
