using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour 
{
	//-- Score --
	//
	public int CurrentScore = 0;

	//-- player Data --
	public int lives = 1;



	// -- block Data --
	//
	public int bricks = 10;
	public GameObject[] block;

	public GameObject score;

	//Block spawn Locations
	public float xmin;
	public float ymin;


	// Use this for initialization
	void Start () 
	{
		
		//s_Block = GameObject.FindGameObjectsWithTag ("Block");
		CurrentScore = 0;
		SpawnBlock ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		CurrentScore = Blocks.GetScore ();
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
}
