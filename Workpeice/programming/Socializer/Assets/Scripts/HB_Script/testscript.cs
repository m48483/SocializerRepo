using Fungus;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class testscript : MonoBehaviour
{
   
    public void asd()
    {
        GameObject go = GameObject.Find("SayDialog");

        //GameObject go = GameObject.Find("SayDialog");

        GameObject.Find("SayDialog").GetComponent<SayDialog>().enabled = false;
        if (go)
        {
            Debug.Log(go.name);
        }
        else
        {
            Debug.Log("No game object called wibble found");
        }
    }

}