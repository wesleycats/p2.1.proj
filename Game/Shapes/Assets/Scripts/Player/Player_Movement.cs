using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

	float _PlayerCurrentX;
	float _PlayerCurrentY;
	float _PlayerYUpdated = 0;
	float _Gravity = 0.999f;
	float _JumpingForce = 0;
	[SerializeField]
	float _Step = 0;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update() {
		_PlayerCurrentX = gameObject.transform.position.x;
		_PlayerCurrentY = gameObject.transform.position.y;


		if (transform.position.y <= 3) {
			if (Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.UpArrow))
			{

				StartCoroutine("Jumping");

			}
		}

		if (transform.position.y >= -3)
		{
			if (Input.GetKeyDown("s") || Input.GetKeyDown(KeyCode.DownArrow))
			{

				StartCoroutine("Dropping");

			}
		}

		
		

		
		gameObject.transform.position = new Vector3(_PlayerCurrentX,_PlayerCurrentY + _JumpingForce);
	}

	// Jumping handels the jumping of the character
	private IEnumerator Jumping()
	{
		//print("hai");
		for (float i = 0; i < _Step; i++)
		{
			
			_JumpingForce = i / _Step;
			
			yield return null;
		}
		_JumpingForce = 0;
	}
	
	// Dropping handels the falling down of the character
	private IEnumerator Dropping()
	{
		//print("hai");
		for (float i = 0; i < _Step; i++)
		{
			//print("hai");
			_JumpingForce = - i / _Step;

			yield return null;
		}
		_JumpingForce = 0;
	}
}
