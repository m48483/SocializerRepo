using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialReset : MonoBehaviour
{
    public Button btn;


    void Start()
    {
        //SceneManager.LoadScene("Popup", LoadSceneMode.Additive);
        btn = transform.Find("DelayButton").GetComponent<Button>();
    }

}
