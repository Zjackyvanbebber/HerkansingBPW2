using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StartDialog : Interactable
{
    public string[] dialogue;
    public string name;

    private void Start()
    {
        Interact();
    }

    public override void Interact()
    {
        FindObjectOfType<AudioManager>().Play("Voice3Female");
        DialogSystem.Instance.AddNewDialogue(dialogue, name);
        Debug.Log("Interacting with NPC.");
    }
}
