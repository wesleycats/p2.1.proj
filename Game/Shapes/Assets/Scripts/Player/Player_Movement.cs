using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

	float _PlayerCurrentX;
	float _PlayerCurrentY;
	float _PlayerXUpdated = 0;
	float _Gravity = 0.999f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_PlayerCurrentX = gameObject.transform.position.x;
		_PlayerCurrentY = gameObject.transform.position.y;

		if (Input.GetButtonDown("Jump"))
		{
			_PlayerXUpdated = 0.1f;
		}

		_PlayerXUpdated-= _Gravity;




		gameObject.transform.position = new Vector3(_PlayerCurrentX,_PlayerCurrentY + _PlayerXUpdated);
	}
}
