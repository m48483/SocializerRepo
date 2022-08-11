using Fungus;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class testscript : MonoBehaviour
{
    public void Click_D()
    {
        GameObject go = GameObject.Find("SayDialog");


        GameObject.Find("SayDialog").GetComponent<SayDialog>().enabled = false;
       
    }
    public void ClickOn()
    {
        GameObject go = GameObject.Find("SayDialog");


        GameObject.Find("SayDialog").GetComponent<SayDialog>().enabled = true;

    }
    public void obverbationBtn_ClickD()
    {
        GameObject.Find("SayDialog").transform.Find("Panel").transform.Find("Button").transform.Find("Observation_btn").GetComponent<testscript>().enabled = false;

    }
    public void obverbationBtn_ClickOn()
    {
        GameObject.Find("SayDialog").transform.Find("Panel").transform.Find("Button").transform.Find("Observation_btn").GetComponent<testscript>().enabled = true;

    }
}


