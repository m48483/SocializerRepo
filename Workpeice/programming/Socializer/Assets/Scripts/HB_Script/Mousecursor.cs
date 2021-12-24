using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousecursor : MonoBehaviour
{
    [SerializeField] Texture2D cursorImg1;
    [SerializeField] Texture2D cursorImg2;
    private Vector2 hotSpot;

    public void CursorChange_On()
    {
        hotSpot.x = cursorImg1.width / 3;
        hotSpot.y = cursorImg1.height / 3;
        Cursor.SetCursor(cursorImg1, hotSpot, CursorMode.ForceSoftware);
    }
    
    public void CursorChange_Off()
    {
        
        Cursor.SetCursor(cursorImg2, Vector2.zero, CursorMode.ForceSoftware);
    }
}
