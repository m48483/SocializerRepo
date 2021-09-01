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
            Debug.Log("플로우차트를 클릭 못해야함");
            btn.SetActive(false);
        }

        if (!msr.Pause)
        {
            Debug.Log("플로우차트 클릭 가능");
            btn.SetActive(true);
        }
    }


}
