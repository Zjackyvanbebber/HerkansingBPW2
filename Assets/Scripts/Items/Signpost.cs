﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signpost : ActionItem {
    public string[] dialogue;
    public override void Interact()
    {
        DialogSystem.Instance.AddNewDialogue(dialogue, "Sign");
        Debug.Log("interacting with Signpost.");
    }


}

