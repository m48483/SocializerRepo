using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Schedule_Button : MonoBehaviour
{
    public GameObject Button;
    [SerializeField] Texture2D cursorImg;
    public void Clicked()
    {
        Button = EventSystem.current.currentSelectedGameObject;

        if(Button.name == "Observation_btn")
        {
            Cursor.SetCursor(cursorImg, Vector2.zero, CursorMode.ForceSoftware);
            Debug.Log("관찰 버튼 클릭");
            //sendmsg
        }
        
        else if(Button.name == "Action_btn")
        {
            GameObject.Find("SayDialog").transform.Find("Panel").transform.Find("Button").transform.Find("Pass_btn").gameObject.SetActive(true);
            GameObject.Find("SayDialog").transform.Find("Panel").transform.Find("Button").transform.Find("Arrest_btn").gameObject.SetActive(true);
            GameObject.Find("SayDialog").transform.Find("Panel").transform.Find("Button").transform.Find("Kill_btn").gameObject.SetActive(true);
            Debug.Log("행동 버튼 클릭");

        }
    }
}
