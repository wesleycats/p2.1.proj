using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

	float _PlayerCurrentX;
	float _PlayerCurrentY;
	//float _PlayerYUpdated = 0;
	//float _Gravity = 0.999f;
	float _JumpingForce = 0;
    float _MoveSpeed = 0.001f;

    // Use this for initialization
    void Start () {
        
    }

	// Update is called once per frame
	void Update() {
		_PlayerCurrentX = gameObject.transform.position.x;
		_PlayerCurrentY = gameObject.transform.position.y;

		if (Input.GetKeyDown(KeyCode.W))
		{
			//print("up");
            StartCoroutine("Up");
            //_PlayerCurrentY += 2.175f;
        }

		if (Input.GetKeyDown(KeyCode.S))
		{
			StartCoroutine("Down");
			// _PlayerCurrentY -= 2.175f;
		}

		//gameObject.transform.position = new Vector3(_PlayerCurrentX,_PlayerCurrentY + _JumpingForce);
	}

    private IEnumerator Up()
    {
		print("up");
		if (_PlayerCurrentY == 2.175f)
        {
            for (float i = _PlayerCurrentY; i <= 4.35f; i += 0.2175f)
            {
                _PlayerCurrentY = i;
                gameObject.transform.position = new Vector3(_PlayerCurrentX, _PlayerCurrentY);
                yield return new WaitForSeconds(_MoveSpeed);
            }
        }

        if (_PlayerCurrentY == -2.175f)
        {
            for (float i = _PlayerCurrentY; i <= 0; i += 0.2175f)
            {
                _PlayerCurrentY = i;
                gameObject.transform.position = new Vector3(_PlayerCurrentX, _PlayerCurrentY);
                yield return new WaitForSeconds(_MoveSpeed);
            }
            gameObject.transform.position = new Vector3(_PlayerCurrentX, 0);
        }

        if (_PlayerCurrentY == 0)
        { 
            for (float i = _PlayerCurrentY; i <= 2.175f; i += 0.2175f)
            {
                _PlayerCurrentY = i;
                gameObject.transform.position = new Vector3(_PlayerCurrentX, _PlayerCurrentY);
                yield return new WaitForSeconds(_MoveSpeed);
            }
        }

        if (_PlayerCurrentY == -4.35f)
        {
            for (float i = _PlayerCurrentY; i <= -2.175f; i += 0.2175f)
            {
                _PlayerCurrentY = i;
                gameObject.transform.position = new Vector3(_PlayerCurrentX, _PlayerCurrentY);
                yield return new WaitForSeconds(_MoveSpeed);
            }
        }
    }

    private IEnumerator Down()
    {
		
		if (_PlayerCurrentY == -2.175f)
        {
            for (float i = _PlayerCurrentY; i >= -4.35f; i -= 0.2175f)
            {
                _PlayerCurrentY = i;
                gameObject.transform.position = new Vector3(_PlayerCurrentX, _PlayerCurrentY);
                yield return new WaitForSeconds(_MoveSpeed);
            }
        }

        if (_PlayerCurrentY == 0)
        {
            for (float i = _PlayerCurrentY; i >= -2.175f; i -= 0.2175f)
            {
                _PlayerCurrentY = i;
                gameObject.transform.position = new Vector3(_PlayerCurrentX, _PlayerCurrentY);
                yield return new WaitForSeconds(_MoveSpeed);
            }
        }

        if (_PlayerCurrentY == 2.175f)
        {
            for (float i = _PlayerCurrentY; i > 0; i -= 0.2175f)
            {
                _PlayerCurrentY = i;
                gameObject.transform.position = new Vector3(_PlayerCurrentX, _PlayerCurrentY);
                yield return new WaitForSeconds(_MoveSpeed);
            }
            gameObject.transform.position = new Vector3(_PlayerCurrentX, 0);
        }


        if (_PlayerCurrentY == 4.35f)
        {
            for (float i = _PlayerCurrentY; i >= 2.175f; i -= 0.2175f)
            {
                _PlayerCurrentY = i;
                gameObject.transform.position = new Vector3(_PlayerCurrentX, _PlayerCurrentY);
                yield return new WaitForSeconds(_MoveSpeed);
            }
        }
    }
}
