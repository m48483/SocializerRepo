using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SoundManager : MonoBehaviour
{
    public AudioClip clickSound;
    
    private Button button
    {
        get
        {
            return GetComponent<Button>();
        }
    }
    private AudioSource source
    {
        get
        {
            return GetComponent<AudioSource>();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = clickSound;
        source.playOnAwake = false;

        button.onClick.AddListener(() => PlaySound());
    }

    public void PlaySound()
    {
        source.PlayOneShot(clickSound);
        source.Play();
    }
}
