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

    public Text PassTxt;
    public Text SpecialTxt;
    public Text CitizenTxt;
    public Text DieTxt;
    public Text reactionistTxt;

    // Start is called before the first frame update
    void Awake()
    {
        _sceneChange = FindObjectOfType<SceneChange>();
        /*
        PassTxt = FindObjectOfType<pass>();
        SpecialTxt = FindObjectOfType<special>();
        CitizenTxt = FindObjectOfType<citizen>();
        DieTxt = FindObjectOfType<reactionist>();
        reactionistTxt = FindObjectOfType<die>();
        */
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
        if(rm)
            _sceneChange.Init_UIChange();
    }
}
