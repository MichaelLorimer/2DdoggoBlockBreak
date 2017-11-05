using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour 
{
	//-----------------
	// -- Block Data --
	//
	public static int Score;  // current Score (Static) so it canbe accessed in BoardManager for score purposes
	public static int PointVal = 5;  //how many points agiven block is worth


	void Start()
	{
		Score = 0;
	}
		
	void OnCollisionEnter2D(Collision2D col)
	{
		// Update different vlaues for different blocks
		UpdateScore ();
		Destroy (gameObject);

	}

	int UpdateScore()
	{
		Score += PointVal;
		return Score;
	}

	public static int GetScore()
	{
		return Score;
	}
}
