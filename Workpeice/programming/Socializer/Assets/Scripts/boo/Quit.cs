using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void QuitButton() //나가기
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false; //유니티 에디터에서 플레이모드 false로, 나중에 지울 부분
    }
}
