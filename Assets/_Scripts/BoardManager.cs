using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardManager : MonoBehaviour 
{
	//-- Score --
	//
	public int CurrentScore = 0;

	//-- player Data --
	public int lives = 1;

	//Ball
	public GameObject ball;

	// -- block Data --
	//
	public int bricks = 10;
	public GameObject[] block;

	public GameObject score;

	//Block spawn Locations
	public float xmin;
	public float ymin;

	//--- UI Elements --
	public Text text;
	public Text LifeText;

	// Game Over
	private bool GameOver = false;

	// Use this for initialization

	void Awake()
	{
		//Set Text reference 
		CurrentScore = 0; 
		lives = 3;
	}

	void Start () 
	{
		SpawnBlock ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		UpdateText ();

		//Check if the Ball is below the board
		if (ball.transform.localPosition.y < -120) 
		{
			lives--;
		}

		if (lives < 0) 
		{
			GameOver = true;	
		}

		CheckGameOver ();
	}

	//Function to spawn blocks 
	void SpawnBlock()
	{
		for (int j = 0; j < 5; j++) 
		{
			for (int i = 0; i < bricks; i++) 
			{
				Instantiate (block [j]);
				block [j].transform.position = new Vector2 (xmin, ymin);
				xmin += 18.5f;
			}
			xmin = -95;
			ymin -= 15.0f;
		}
	}

	void UpdateText()
	{
		//Score Upate
		CurrentScore = Blocks.GetScore ();
		text.text = "Score: " + CurrentScore;

		//Lives Update
		LifeText.text = "Lives: " + lives;

	}

	void CheckGameOver()
	{
		if (GameOver) 
		{
			LifeText.text = "Game Over";
			if (Input.GetKey ("r")) 
			{
				LifeText.text = "Restart";
				lives = 3;
				GameOver = false;
			}
		}
	}
}
