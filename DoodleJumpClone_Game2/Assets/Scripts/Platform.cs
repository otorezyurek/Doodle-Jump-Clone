using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

	public float jumpPower;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.relativeVelocity.y <= 0)
		{
			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
			if (rb != null)
			{
				Vector2 playerVelocity = rb.velocity;
				playerVelocity.y = jumpPower;
				rb.velocity = playerVelocity;
			}
		}
		
	}

}
