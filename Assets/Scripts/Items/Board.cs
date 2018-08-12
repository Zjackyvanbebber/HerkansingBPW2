using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : ActionItem {
    public string[] dialogue;
    public override void Interact()
    {
        DialogSystem.Instance.AddNewDialogue(dialogue, "Board");
        Debug.Log("interacting with Board.");
    }


}

