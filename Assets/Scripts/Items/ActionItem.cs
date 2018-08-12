using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionItem : Interactable {
    public virtual void interact() {

        Debug.Log("interacting with base Action item");
	}
}
