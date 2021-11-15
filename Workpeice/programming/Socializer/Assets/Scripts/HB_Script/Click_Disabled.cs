using Fungus;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Click_Disabled : MonoBehaviour
{
   
    public void Click_D()
    {
        GameObject go = GameObject.Find("SayDialog");


        GameObject.Find("SayDialog").GetComponent<SayDialog>().enabled = false;

    }
    public void Activation()
    {
        GameObject go = GameObject.Find("SayDialog");


        GameObject.Find("SayDialog").GetComponent<SayDialog>().enabled = true;
    }

}