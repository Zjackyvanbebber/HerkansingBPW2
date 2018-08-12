using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerNextLevel : MonoBehaviour {

    private void OnTriggerEnter()
    {
        FindObjectOfType<AudioManager>().Play("Transi");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

}
   

