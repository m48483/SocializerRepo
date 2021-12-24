using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Schedule_Button : MonoBehaviour
{
    public GameObject Button;
    public int Actiononoff = 0;
    public int Evidenceonoff = 0;
    [SerializeField] Texture2D cursorImg1;
    [SerializeField] Texture2D cursorImg2;


    public void Clicked()
    {
        Button = EventSystem.current.currentSelectedGameObject;
        if(Button.name == "Observation_btn")
        {
            switch (Actiononoff) {
                case 0:
                    Debug.Log("관찰 활성화");
                    Actiononoff = 1;
                    //Cursor.SetCursor(cursorImg1, Vector2.zero, CursorMode.ForceSoftware);
                    GameObject.Find("SayDialog").transform.Find("Panel").GetComponent<Mousecursor>().CursorChange_On();
                    GameObject.Find("StoryText").GetComponent<Text_Clickable>().enabled = true;
                    GameObject.Find("StoryText").GetComponent<Text_Event>().Store();
                    GameObject.Find("SayDialog").GetComponent<DialogInput>().enabled = false;
                    GameObject.Find("SayDialog").transform.Find("Panel").transform.Find("Button").transform.Find("Evidence_btn").gameObject.SetActive(false);
                    break;

                case 1:
                    Debug.Log("관찰 비활성화");
                    Actiononoff = 0;
                    //Cursor.SetCursor(cursorImg2, Vector2.zero, CursorMode.ForceSoftware);
                    GameObject.Find("SayDialog").transform.Find("Panel").GetComponent<Mousecursor>().CursorChange_Off();
                    GameObject.Find("StoryText").GetComponent<Text_Clickable>().enabled = false;
                    GameObject.Find("SayDialog").GetComponent<DialogInput>().enabled = true;
                    GameObject.Find("SayDialog").transform.Find("Panel").transform.Find("Button").transform.Find("Evidence_btn").gameObject.SetActive(true);
                    break;                
            }
        }
        
        else if(Button.name == "Action_btn")
        {
            GameObject.Find("SayDialog").transform.Find("Panel").transform.Find("Button").transform.Find("Pass_btn").gameObject.SetActive(true);
            GameObject.Find("SayDialog").transform.Find("Panel").transform.Find("Button").transform.Find("Arrest_btn").gameObject.SetActive(true);
            GameObject.Find("SayDialog").transform.Find("Panel").transform.Find("Button").transform.Find("Kill_btn").gameObject.SetActive(true);
            Debug.Log("행동 버튼 클릭");

        }
        else if (Button.name == "Evidence_btn")
        {
            switch (Evidenceonoff)
            {
                case 0:
                    Debug.Log("증거 활성화");
                    Evidenceonoff = 1;
                    GameObject.Find("SayDialog").transform.Find("Evidence_UI").gameObject.SetActive(true);
                    break;
                case 1:
                    Debug.Log("증거 비활성화");
                    Evidenceonoff = 0;
                    GameObject.Find("SayDialog").transform.Find("Evidence_UI").gameObject.SetActive(false);
                    break;
            }
            
        }
    }
}
