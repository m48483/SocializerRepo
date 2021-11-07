using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowstop : MonoBehaviour
{
    MsgReceive msr;
    public GameObject flowchart;
    public GameObject btn;

    private void Awake()
    {
         msr = FindObjectOfType<MsgReceive>();
    }
    
    void Update()
    {
        if (msr.Pause)
        {
            btn.SetActive(false);
        }

        if (!msr.Pause)
        {
            btn.SetActive(true);
        }
    }
}
