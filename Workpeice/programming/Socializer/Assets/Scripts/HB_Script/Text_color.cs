using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    public string str;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        GetComponent<TextMesh>().color = new Color(0, 1, 0, 1);
        //str = GetComponent<TextMesh>().text;
        Debug.Log(str);
    }
}
