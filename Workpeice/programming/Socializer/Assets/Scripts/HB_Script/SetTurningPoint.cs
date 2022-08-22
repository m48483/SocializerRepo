using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SetTurningPoint : MonoBehaviour
{
    public void revolutionaryRouteOpen()
    {
        PlayerPrefs.SetInt("Revolutionary_route", 1);
        GameObject.Find("Variables").GetComponent<Flowchart>().SetIntegerVariable("Revolutionary_route", 1);
    }
    public void Ending1()
    {
        PlayerPrefs.SetInt("Ending1", 1);
    }
    public void Ending2()
    {
        PlayerPrefs.SetInt("Ending2", 1);
    }
}
