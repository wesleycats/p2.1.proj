using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Handeler : MonoBehaviour {

	/// <summary>
	/// This class is used for handeling the life and score of the player.
	/// </summary>

	int _Score = 0;
	int _Lives = 5;
	
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//print("Lives are: " + _Lives);
		//print("Score is: " + _Score);

	}


	//This OnCollisionEnter is used to look if it is touching a wall and if so, it compairs the players wallvalue with the wall's wallvalue.
	//If it is the same then it wil destroy the wall and adds 100 to the score. Else it wil detract 50 from the score, the wall will be destroyed and the player loses a life

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Wall")
		{
			if (coll.gameObject.GetComponent<WallCounter>()._WallValue == gameObject.GetComponent<Player_ShapeChange>()._ShapeValue)
			{

				_Score += 100;
				Destroy(coll.gameObject);
			}
			else
			{
				_Score -= 50;
				_Lives -= 1;
				Destroy(coll.gameObject);
			}
		}


	}
}
