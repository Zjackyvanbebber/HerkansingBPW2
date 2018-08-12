using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : ActionItem {
    public string[] dialogue;
    public override void Interact()
    {
        DialogSystem.Instance.AddNewDialogue(dialogue, "Lamp");
        Debug.Log("interacting with Lamp.");
    }


}

