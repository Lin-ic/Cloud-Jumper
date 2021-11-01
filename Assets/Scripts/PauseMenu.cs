using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false;

    public GameObject pauseMenu;

    // Update is called once per frame
    // When the Escape Key is pressed:
    // The game will be Paused, else the game will Resume
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPaused)
            {
                ResumeGame();
            }
        else
            {
                PauseGame();
            }
        }
    }

    // When game is Paused:
    // Time is stopped
    // and the Pause Menu will appear
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }

    // On the Pause Menu:
    // When game is Resumed:
    // Time is active
    // and the Pause Menu will disappear
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    // On the Pause Menu:
    // When the button 'Menu' is pressed:
    // Time is set to active
    // Scene Manager will load the scene named menu "Menu"
    // In the console log "Loading Menu..." will be displayed
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("Loading Menu...");
        SceneManager.LoadScene("Menu");
    }

    // On the Pause Menu:
    // When the button 'Quit' is pressed:
    // The application will close.
    // In the console log "Quitting Game..." will be displayed
    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
