using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player_Handeler : MonoBehaviour {

	/// <summary>
	/// This class is used for handeling the life and score of the player.
	/// </summary>

	int _Score = 0;
	int _Lives = 5;
	bool _Shielding = false;
	[SerializeField]
	Text _LivesText;
	[SerializeField]
	Text _ScoreText;
	
	

	// Use this for initialization
	void Start () {
        print("Lives are: " + _Lives);
        print("Score is: " + _Score);
		
		
    }
	
	// Update is called once per frame
	void Update () {

		_ScoreText.text = "Score: " + _Score;
		_LivesText.text = "Lives: " + _Lives;

		if (_Lives <= 0)
		{
			//Death

		}

	}


	//This OnCollisionEnter is used to look if it is touching a wall and if so, it compairs the players wallvalue with the wall's wallvalue.
	//If it is the same then it wil destroy the wall and adds 100 to the score. Else it wil detract 50 from the score, the wall will be destroyed and the player loses a life


	void	OnTriggerEnter2D(Collider2D coll)
	{
		//print("Fuck you");
		print(coll.gameObject.GetComponent<Hole_ShapeChanger>());
		if (coll.gameObject.tag == "Hole")
		{

			

			if (coll.gameObject.GetComponent<Hole_ShapeChanger>()._WallValue == gameObject.GetComponent<Player_ShapeChange>()._ShapeValue)
			{

				_Score += 100;
				//Destroy(coll.gameObject);
			}
			else
			{
				_Score -= 50;
				_Lives -= 1;
				//Destroy(coll.gameObject);
			}
			StartCoroutine("Shield");
		}
		else if (_Shielding == false)
		{
			_Score -= 50;
			_Lives -= 1;
		}

		
	}

	private IEnumerator Shield()
	{
		for (int i = 0; i < 1; i++)
		{
			_Shielding = true;
			yield return new WaitForSeconds(1);
		}
		_Shielding = false;
	}

}

