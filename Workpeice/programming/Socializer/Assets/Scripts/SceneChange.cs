using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void TitleChange()
    {
        SceneManager.LoadScene("Title");
    }
    public void PrologueChange()
    {
        SceneManager.LoadScene("Prologue");
    }
}
