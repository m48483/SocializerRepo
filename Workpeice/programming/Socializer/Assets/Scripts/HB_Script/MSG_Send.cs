using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MSG_Send : MonoBehaviour
{
    public GameObject ConversationButton;
   
    public void Clicked()
    {
        ConversationButton = EventSystem.current.currentSelectedGameObject;
        //GameObject.Find("Canvas").transform.FindChild("DelayButton").gameObject.SetActive(true);
        Debug.Log(ConversationButton.name+" 실행했음");
    }

}
