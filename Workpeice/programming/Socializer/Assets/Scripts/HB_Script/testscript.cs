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
        //GameObject.Find("Flowchart").GetComponent<Flowchart>().SetStringVariable("Character", "민초단");
        
        //int i = GameObject.Find("Flowchart1").GetComponent<Flowchart>().GetIntegerVariable("test");
    }

}