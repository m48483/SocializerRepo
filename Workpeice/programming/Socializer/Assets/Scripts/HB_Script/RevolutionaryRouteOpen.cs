using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolutionaryRouteOpen : MonoBehaviour
{
    public void revolutionaryRouteOpen()
    {
        PlayerPrefs.SetInt("Revolutionary_route", 1);
    }
}
