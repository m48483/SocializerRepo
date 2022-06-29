using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetDay : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    public void Update()
    {
        text.text =  GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Day") + "일차";
    }
}
