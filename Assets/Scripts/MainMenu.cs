using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // In the Main Menu, when the button 'Play' is pressed:
    // Unity will load the next scene in the build index, which will be the game.
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // On the Main Menu Screen:
    // When the button 'Quit' is pressed, then Unity will quit the application
    // Int the console log it will display "Quitting Game..."
    public void QuitGame ()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
        
}
