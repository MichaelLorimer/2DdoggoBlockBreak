using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballcontroller : MonoBehaviour 
{
	//Movement speed
	public float speed = 100.0f;
	private Vector2 startVelocity;

	// Use this for initialization
	void Start () 
	{
		// Ball Movement
		GetComponent<Rigidbody2D> ().velocity = Vector2.down * speed;
		startVelocity = GetComponent<Rigidbody2D> ().velocity;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		//function is called when the ball colideswith something
		if (col.gameObject.name == "racket") 
		{
			float x = hitFactor (transform.position, col.transform.position, col.collider.bounds.size.x);

			//Calculate direction, set leangth to 1
			Vector2 dir = new Vector2(x, 1).normalized;

			//Set velocity with dir * speed
			GetComponent<Rigidbody2D>().velocity = dir * speed;
		}
	}

	void Update()
	{
		ballReset ();
	}

	// Function to determine which direction the ball will bounch off the racket
	float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)
	{
		// diagram
		//
		// 1   -0.5   0   0.5   1
		//=======================
		return(ballPos.x - racketPos.x) /racketWidth;
	}

	void ballReset()
	{
		if (GetComponent<Rigidbody2D> ().position.y < -120) 
		{
			GetComponent<Rigidbody2D> ().position = new Vector3 (0.0f, 10.0f, 0.0f);
			GetComponent<Rigidbody2D> ().velocity = startVelocity;
		}
	}
}
