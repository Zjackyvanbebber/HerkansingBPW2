using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : Interactable { 
    public string[] dialogue;
    public string name; 

    public override void Interact()
    {
        FindObjectOfType<AudioManager>().Play("Voice2");
        DialogSystem.Instance.AddNewDialogue(dialogue, name);
        Debug.Log("Interacting with NPC.");
    }
}
