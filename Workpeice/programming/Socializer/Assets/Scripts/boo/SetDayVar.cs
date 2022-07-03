using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDayVar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int day;
        day = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Day");
        Debug.Log(day);
        day++;
        Debug.Log(day);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Day", day);
    }
}
