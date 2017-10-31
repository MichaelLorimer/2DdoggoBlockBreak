using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour 
{
	//-----------------
	// -- Block Data --
	//
	public int Score;     // current Score
	public int pointVal = 1;  //how many points agiven block is worth


	void Start()
	{
		Score = 0;
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		Destroy (gameObject);
		Score += pointVal;

	}
}
