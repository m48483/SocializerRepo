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

}