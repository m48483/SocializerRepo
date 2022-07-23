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
        PassTxt.text = "\t통과한 인원 :\t" +
            GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Pass").ToString() + "명";
        SpecialTxt.text = "\t특별 감시 필요 :\t" + 
            GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Arrest").ToString() + "명";
        CitizenTxt.text = "\t시민 :\t" + 
            GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Citizen").ToString() + "명";
        DieTxt.text = "사살한 인원 :\t" + 
            GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Kill").ToString() + "명";
        reactionistTxt.text = "\t반동분자 :\t" +
            GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("ReactionaryNPC").ToString() + "명";

    }
}

