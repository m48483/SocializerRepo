using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Reactionary_Check : MonoBehaviour
{

    public void Pass_Check()
    {
        // 반동분자 라면 호감도 감소

        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Hilda_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability") - 5.0f);
        //PlayerPrefs.SetFloat("Hilda_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability"));

        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability") - 5.0f);
        //PlayerPrefs.SetFloat("Dylan_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));

        if (PlayerPrefs.GetInt("Revolutionary_route") == 1)
        {
            GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Frances_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability") + 4.0f);
            //PlayerPrefs.SetFloat("Frances_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability"));
        }

    }
    public void Arrest_Citizen()
    {
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Hilda_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability") - 0.5f);
        //PlayerPrefs.SetFloat("Hilda_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability"));
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability") - 0.5f);
        //PlayerPrefs.SetFloat("Dylan_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));
        if (PlayerPrefs.GetInt("Revolutionary_route") == 1)
        {
            GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Frances_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability") - 0.5f);
            //PlayerPrefs.SetFloat("Frances_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability"));
        }
    }
    public void Arrest_ReactionaryNPC()
    {
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Hilda_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability") + 0.5f);
        //PlayerPrefs.SetFloat("Hilda_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability"));
    }
    public void Kill_Check()
    {
        //반동분자 사살, 시민 사살시에는 호감도 변경 x??
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Hilda_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability") + 3.0f);
        //PlayerPrefs.SetFloat("Hilda_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability"));
        GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability") + 3.0f);
        //PlayerPrefs.SetFloat("Dylan_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));
        if (PlayerPrefs.GetInt("Revolutionary_route") == 1)
        {
            GameObject.Find("Variables").GetComponent<Flowchart>().SetFloatVariable("Frances_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability") - 1.0f);
            //PlayerPrefs.SetFloat("Frances_reliability", GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Frances_reliability"));

        }

    }
}
