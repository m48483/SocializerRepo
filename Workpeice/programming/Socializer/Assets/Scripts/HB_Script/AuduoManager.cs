using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;
public class AuduoManager : MonoBehaviour
{
    public string SceneName;
    public AudioSource[] audioSource;
    public float Heather_reliability;
    public float Dylan_reliability;
    // Start is called before the first frame update
    void Start()
    {
        Heather_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Heather_reliability");
        Dylan_reliability = GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability");

        SceneName = SceneManager.GetActiveScene().name;
        Debug.Log(SceneName);
        BGMSet();
    }

    // Update is called once per frame
    public void BGMSet()
    {
        if (SceneName.Equals("House"))
        {
            if(Heather_reliability > 60)
            {
                audioSource[0].Play();
            }
            else if (Heather_reliability <= 60)
            {
                audioSource[1].Play();
            }
        }
    }
}
