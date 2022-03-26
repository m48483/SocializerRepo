using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Report : MonoBehaviour
{
    private WaitForSecondsRealtime _UIDelay1 = new WaitForSecondsRealtime(0.01f);
    SceneChange _sceneChange;
    bool rm = false;

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
