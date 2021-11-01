using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public PlayerMovement movement;
    private AudioSource fallSfx;

    // When program starts, the fallSFX will be gotten as an AudioSource
    void Start()
    {
        fallSfx = GetComponent<AudioSource>();
    }


    // On collision, if the collision on colliders that have the tag "Player"
    // The movement of the player and time in the program will be stopped and the fallSfx/Death sound will play
    // In the console log it will display "You Died"
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("You Died!");
            movement.enabled = false;
            Time.timeScale = 0f;
            fallSfx.Play();
        }
    }
}
