using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuMain : MonoBehaviour
{
    // Start Game Play
    public void StartNewGame()
    {
        SceneManager.LoadScene("menu_Dummy");
    }

    //General function for changing scenes
    public void ChangeScene(string sceneName)
	{
        
		Debug.Log("SCENE: Attempting to change to scene: " + sceneName);
	    SceneManager.LoadScene(sceneName);
	}

    //Function for exitting game
    public void QuitGame()
    {
		Debug.Log("SCENE: Attempting to exit game");
        Application.Quit();
		Debug.Log("SCENE: Game successfully quit");
    }

}
