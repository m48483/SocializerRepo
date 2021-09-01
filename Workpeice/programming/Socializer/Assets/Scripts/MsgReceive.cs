using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MsgReceive : MonoBehaviour
{
    public GameObject flowchart;

    public bool Pause;

    public void Awake()
    {
        Pause = false;
    }

    public void PauseMenuOn()
    {
        Pause = true;
    }

    public void PauseMenuOff()
    {
        Pause = false;
    }

}
