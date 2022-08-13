using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emergency : MonoBehaviour
{
    // Start is called before the first frame update
    public void EmergencySetting()
    {
        GameObject.Find("Variables").GetComponent<Flowchart>().SetBooleanVariable("Daily_schedule", true);
    }
}
