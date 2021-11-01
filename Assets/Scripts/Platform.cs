using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

	public float jumpForce = 10f;

	// On Collision:
	// If a collider collides with the platform equal to 0, relative to the velocity of y:
	// Only then will the code commence
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.relativeVelocity.y <= 0f)
		{
			// If the collider tag is "Player":
			// Then Object will be destroyed on collision
			if (collision.collider.tag == "Player")
			{
				Destroy(gameObject);
			}

			// Sets how high an object (with a rb) will go (on the y axis) when colliding with the platform
			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
			if (rb != null)
			{
				Vector2 velocity = rb.velocity;
				velocity.y = jumpForce;
				rb.velocity = velocity;
			}
		}
	}
}
