using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountVarReport : MonoBehaviour
{
    public Text PassTxt;
    public Text SpecialTxt;
    public Text CitizenTxt;
    public Text DieTxt;
    public Text reactionistTxt;
    // Start is called before the first frame update
    void Start()
    {
        PassTxt.text = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Pass").ToString();
        SpecialTxt.text = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Arrest").ToString();
        CitizenTxt.text = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Citizen").ToString();
        DieTxt.text = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Kill").ToString();
        reactionistTxt.text = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("ReactionaryNPC").ToString();

    }
}

