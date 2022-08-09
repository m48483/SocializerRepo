using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SetName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Character").transform.Find("Player").GetComponent<Character>().
            NameText = PlayerPrefs.GetString("Name");
    }

    
}
