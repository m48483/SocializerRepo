﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallFadeEffect : MonoBehaviour
{
    // Start is called before the first frame update
    public void callFadeEffect()
    {
        Debug.Log("페이드인아웃");
        GameObject.Find("Munu").transform.Find("PopupCanvas ").GetComponent<Fadeout>().FadeEffect();
    }
}