using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketController : MonoBehaviour 
{
	//Racket data 
	int lives = 3;

	// Movement Speed
	public Rigidbody2D racket;
	public float speed = 150;

	// Fixed update for physics objects 
	void FixedUpdate ()
	{
		//Get input Horizontal (left, right)
		float hor = Input.GetAxisRaw("Horizontal");

		//Set velocity to movement direction * speed
		GetComponent <Rigidbody2D> ().velocity = Vector2.right * hor * speed;
	}
}
