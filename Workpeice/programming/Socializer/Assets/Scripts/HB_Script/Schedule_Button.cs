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

        if(Button.name == "Observation")
        {
            Cursor.SetCursor(cursorImg, Vector2.zero, CursorMode.ForceSoftware);
            Debug.Log("관찰 버튼 클릭");
            //sendmsg
        }
        
        else if(Button.name == "Action")
        {
            GameObject.Find("Canvas").transform.FindChild("Pass").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.FindChild("Arrest").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.FindChild("Kill").gameObject.SetActive(true);
            Debug.Log("행동 버튼 클릭");

        }
    }
}
