using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    
    public void PlayGame()
    {
        FindObjectOfType<AudioManager>().Play("Transi");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        //("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quiting the game...");
    }
   
}
