using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Reactionarymolecule_Check : MonoBehaviour
{
    float Hilda_reliability;
    float Heather_reliability;
    float Frances_reliability;
    float Dylan_reliability;
    bool Reactionary_molecule;
    bool Revolutionary_route;

    void Start()
    {
        Hilda_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability");
        Heather_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability");
        Frances_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability");
        Dylan_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability");
        Reactionary_molecule = GameObject.Find("Flowchart").GetComponent<Flowchart>().GetBooleanVariable("Reactionary_molecule");
        Revolutionary_route = GameObject.Find("Variables").GetComponent<Flowchart>().GetBooleanVariable("Revolutionary_route");
    }

    public void Pass_Check()
    {
        if(Reactionary_molecule == true)
        {
            Hilda_reliability -= 5;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Hilda_reliability", Hilda_reliability);
            if (Revolutionary_route == true)
            {
                Frances_reliability += 4;
                GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Frances_reliability", Frances_reliability);
            }
        }
    }
    public void Arrest_Check()
    {
        if (Reactionary_molecule == true)
        {
            Hilda_reliability += (float)0.5;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Hilda_reliability", Hilda_reliability);
        }
        else if (Reactionary_molecule == false)
        {
            Hilda_reliability -= (float)0.5;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Hilda_reliability", Hilda_reliability);
            if (Revolutionary_route == true)
            {
                Frances_reliability -= (float)0.5;
                GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Frances_reliability", Frances_reliability);
            }
        }
    }
    public void Kill_Check()
    {
        if (Reactionary_molecule == true)
        {
            Hilda_reliability += 3;
            GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Hilda_reliability", Hilda_reliability);
            if (Revolutionary_route == true)
            {
                Frances_reliability -= 1;
                GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Frances_reliability", Frances_reliability);
            }
        }
    }
}
