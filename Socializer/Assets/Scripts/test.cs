using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite npc;
}

public class test : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_npc;
    [SerializeField] private SpriteRenderer sprite_DilalogueBar;
    [SerializeField] private Text txt_Dialpgue;

    private bool isDialogue = false;

    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    public void ShowDialogue()
    {
        OnOff(true);
        count = 0;
        NextDialogue();
    }

    private void OnOff(bool _flag)
    {
        sprite_DilalogueBar.gameObject.SetActive(_flag);
        sprite_npc.gameObject.SetActive(_flag);
        txt_Dialpgue.gameObject.SetActive(_flag);
        isDialogue = _flag;
    }

    private void NextDialogue()
    {
        txt_Dialpgue.text = dialogue[count].dialogue;
        sprite_npc.sprite = dialogue[count].npc;
        count++;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (count < dialogue.Length)
                    NextDialogue();
                else
                    OnOff(false);
            }
        }
    }
}
