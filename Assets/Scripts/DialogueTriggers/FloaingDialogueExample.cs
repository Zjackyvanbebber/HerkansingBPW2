using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//Name the script logically and make it an Interactible like below.
//The object must have a collider that is set as trigger.
//The object can be anything. Dont forget to turm of the renderer.

public class FloaingDialogueExample : Interactable
{
    // Copy over all the code below, Paste it into the new script.
    public string[] dialogue;
    public string name;
    private bool Entered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(Entered == false)
        {
            Interact();
            Entered = true;
        }
    }

    public override void Interact()
    {
        FindObjectOfType<AudioManager>().Play("Gewensde Audiofile");
        DialogSystem.Instance.AddNewDialogue(dialogue, name);
        Debug.Log("Interacting with NPC.");
    }
}
