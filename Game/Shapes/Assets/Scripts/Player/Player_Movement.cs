using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

	float _PlayerCurrentX;
	float _PlayerCurrentY;
	float _PlayerYUpdated = 0;
	float _Gravity = 0.999f;
	float _JumpingForce = 0;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update() {
		_PlayerCurrentX = gameObject.transform.position.x;
		_PlayerCurrentY = gameObject.transform.position.y;

		if (Input.GetKeyDown("w"))
		{
			
			StartCoroutine("Jumping");

		}

		if (Input.GetKeyDown("s"))
		{

			StartCoroutine("Dropping");

		}



		

		
		gameObject.transform.position = new Vector3(_PlayerCurrentX,_PlayerCurrentY + _JumpingForce);
	}

	// Jumping handels the jumping of the character
	private IEnumerator Jumping()
	{
		//print("hai");
		for (float i = 0; i < 15; i++)
		{
			
			_JumpingForce = i / 15;
			
			yield return null;
		}
		_JumpingForce = 0;
	}
	
	// Dropping handels the falling down of the character
	private IEnumerator Dropping()
	{
		//print("hai");
		for (float i = 0; i < 15; i++)
		{
			//print("hai");
			_JumpingForce = - i / 15;

			yield return null;
		}
		_JumpingForce = 0;
	}
}
