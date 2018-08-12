using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour {

    private Animator am;

	// Use this for initialization
	void Start () {
        am = GetComponent<Animator>();
	}

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().Play("Door");
        am.SetTrigger("Open");
    }
}
