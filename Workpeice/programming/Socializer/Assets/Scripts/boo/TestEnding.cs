using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestEnding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GameOverEnding();
    }
    public void AfterDay5()
    {
        SceneManager.LoadScene("Ending2");
    }
    public void GameOverEnding()
    {
        float h = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability");
        float d = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability");

        if(h== 0 && d == 0)
        {
            SceneManager.LoadScene("Ending1");
        }
    }
}
