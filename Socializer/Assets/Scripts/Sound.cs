using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource mySound;
    public AudioClip clickFx;

    public void ClickSound()
    {
        mySound.PlayOneShot(clickFx);
    }
}
