using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour 
{
	//-----------------
	// -- Block Data --
	//

	int numHit;   //Number of hits the block can take 
	int pointVal; //how many points agiven block is worth



	void OnCollisionEnter2D(Collision2D col)
	{
		//Destroy the block
		Destroy (gameObject);
	}
}
