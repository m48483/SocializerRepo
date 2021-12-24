using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomflowchart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int Rand_Flowchart = Random.Range(1, 3);
        GameObject.Find("Random_Flowchart").transform.Find("Flowchart"+ Rand_Flowchart).gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
