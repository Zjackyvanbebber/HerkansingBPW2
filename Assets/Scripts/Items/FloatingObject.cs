using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingObject : ActionItem {
    public string[] dialogue;
    public override void Interact()
    {
        DialogSystem.Instance.AddNewDialogue(dialogue, "-");
        Debug.Log("interacting with Pickup.");
    }


}

