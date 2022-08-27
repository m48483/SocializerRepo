using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Report : MonoBehaviour
{
    private WaitForSecondsRealtime _UIDelay1 = new WaitForSecondsRealtime(0.01f);
    SceneChange _sceneChange;
    SaveManager _saveManager;
    SetDayVar _setDayVar;
    EndingVar _endingVar;

    // Start is called before the first frame update
    void Awake()
    {
        _sceneChange = FindObjectOfType<SceneChange>();
        _saveManager = FindObjectOfType<SaveManager>();
        _setDayVar = FindObjectOfType<SetDayVar>();
        _endingVar = FindObjectOfType<EndingVar>();
    }

    public void Reportmove()
    {
        _setDayVar.setDay();
        _saveManager.GameSave();
        // line 65~76 테스팅
        float h = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability");
        float d = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability");
        if (GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Day") == 61)
        {
            _endingVar.LastDay();
        }
        else if (h == 0 && d == 0)
        {
            SceneManager.LoadScene("Ending1");
        }
        else
        {
            _sceneChange.Daily_scheduleChange();
        }
    }
}
