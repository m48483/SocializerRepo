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
    bool rm = false;

    public GameObject btn;

    // Start is called before the first frame update
    void Awake()
    {
        _sceneChange = FindObjectOfType<SceneChange>();
    }

    void Start()
    {
        StopAllCoroutines();
        StartCoroutine(InDelay());
    }

    IEnumerator InDelay()
    {
        for (int i = 0; i < 105; i++)
        {
            yield return _UIDelay1;
            transform.position -= new Vector3(0, 4f, 0);
        }
        rm = true;
        btn.SetActive(true);
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space)  )
        {
            Reportmove();
        }
    }

    public void Reportmove()
    {
        if (rm)
        {
            // line 65~76 테스팅
            float h = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Hilda_reliability");
            float d = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability");

            if (h == 0 && d == 0)
            {
                SceneManager.LoadScene("Ending1");
            }
            else if (GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Day") > 5)
            {
                SceneManager.LoadScene("Ending2");
                //testEnding.AfterDay5();
            }
            else
            {
                _sceneChange.Init_UIChange();
            }
        }
    }
}
