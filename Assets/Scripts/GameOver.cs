using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject gameOver;
    private AudioSource fallSfx;

    // When program starts, the fallSFX will be gotten as an AudioSource
    void Start()
    {
        fallSfx = GetComponent<AudioSource>();
    }

    // On collision, if the collision on colliders that have the tag "Player"
    // The movement of the player and time in the program will be stopped and the fallSfx/Death sound will play
    // In the console log it will display "You Died"
    // The Game Over Screen will appear
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("You Died!");
            movement.enabled = false;
            Time.timeScale = 0f;
            fallSfx.Play();
            gameOver.SetActive(true);
        }
    }

    // On the Game Over Screen:
    // When the button 'Try Again' is pressed, then Unity's Scene manager will reload the current Scene
    // In the console log it will display "Trying Again..."
    public void TryAgain()
    {
        Time.timeScale = 1f;
        Debug.Log("Trying Again...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // On the Game Over Screen:
    // When the button 'Menu' is pressed, then Unity's Scene manager will load the Main Menu Scene
    // In the console log it will display "Loading Menu..."
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("Loading Menu...");
        SceneManager.LoadScene("Menu");
    }

    // On the Game Over Screen:
    // When the button 'Quit' is pressed, then Unity will quit the application
    // Int the console log it will display "Quitting Game..."
    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }

}