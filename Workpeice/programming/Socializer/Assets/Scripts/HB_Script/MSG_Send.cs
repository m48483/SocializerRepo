using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MSG_Send : MonoBehaviour
{

    void Start()
    {
        GameObject.Find("Canvas").transform.FindChild("DelayButton").gameObject.SetActive(true);
        Debug.Log("실행했음");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
