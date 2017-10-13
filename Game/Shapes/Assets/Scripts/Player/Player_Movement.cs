using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

	float _PlayerCurrentX;
	float _PlayerCurrentY;
	//float _PlayerYUpdated = 0;
	//float _Gravity = 0.999f;
	//float _JumpingForce = 0;
    float _MoveDelay = 0.00001f;
    float _MoveSpeed = 0.2175f;

    // Use this for initialization
    void Start () {
        
    }

	// Update is called once per frame
	void Update() {
		_PlayerCurrentX = gameObject.transform.position.x;
		_PlayerCurrentY = gameObject.transform.position.y;

		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
            StartCoroutine("Up");
            //_PlayerCurrentY += 2.175f;
        }

		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			StartCoroutine("Down");
			// _PlayerCurrentY -= 2.175f;
		}

		//gameObject.transform.position = new Vector3(_PlayerCurrentX,_PlayerCurrentY + _JumpingForce);
	}

    private IEnumerator Up()
    {
		if (_PlayerCurrentY == 2.175f)
        {
            for (float i = _PlayerCurrentY; i <= 4.35f; i += _MoveSpeed)
            {
                _PlayerCurrentY = i;
                gameObject.transform.position = new Vector3(_PlayerCurrentX, _PlayerCurrentY);
                yield return new WaitForSeconds(_MoveDelay);
            }
        }

        if (_PlayerCurrentY == -2.175f)
        {
            for (float i = _PlayerCurrentY; i <= 0; i += _MoveSpeed)
            {
                _PlayerCurrentY = i;
                gameObject.transform.position = new Vector3(_PlayerCurrentX, _PlayerCurrentY);
                yield return new WaitForSeconds(_MoveDelay);
            }
            gameObject.transform.position = new Vector3(_PlayerCurrentX, 0);
        }

        if (_PlayerCurrentY == 0)
        { 
            for (float i = _PlayerCurrentY; i <= 2.175f; i += _MoveSpeed)
            {
                _PlayerCurrentY = i;
                gameObject.transform.position = new Vector3(_PlayerCurrentX, _PlayerCurrentY);
                yield return new WaitForSeconds(_MoveDelay);
            }
        }

        if (_PlayerCurrentY == -4.35f)
        {
            for (float i = _PlayerCurrentY; i <= -2.175f; i += _MoveSpeed)
            {
                _PlayerCurrentY = i;
                gameObject.transform.position = new Vector3(_PlayerCurrentX, _PlayerCurrentY);
                yield return new WaitForSeconds(_MoveDelay);
            }
        }
    }

    private IEnumerator Down()
    {
		
		if (_PlayerCurrentY == -2.175f)
        {
            for (float i = _PlayerCurrentY; i >= -4.35f; i -= _MoveSpeed)
            {
                _PlayerCurrentY = i;
                gameObject.transform.position = new Vector3(_PlayerCurrentX, _PlayerCurrentY);
                yield return new WaitForSeconds(_MoveDelay);
            }
        }

        if (_PlayerCurrentY == 0)
        {
            for (float i = _PlayerCurrentY; i >= -2.175f; i -= _MoveSpeed)
            {
                _PlayerCurrentY = i;
                gameObject.transform.position = new Vector3(_PlayerCurrentX, _PlayerCurrentY);
                yield return new WaitForSeconds(_MoveDelay);
            }
        }

        if (_PlayerCurrentY == 2.175f)
        {
            for (float i = _PlayerCurrentY; i > 0; i -= _MoveSpeed)
            {
                _PlayerCurrentY = i;
                gameObject.transform.position = new Vector3(_PlayerCurrentX, _PlayerCurrentY);
                yield return new WaitForSeconds(_MoveDelay);
            }
            gameObject.transform.position = new Vector3(_PlayerCurrentX, 0);
        }


        if (_PlayerCurrentY == 4.35f)
        {
            for (float i = _PlayerCurrentY; i >= 2.175f; i -= _MoveSpeed)
            {
                _PlayerCurrentY = i;
                gameObject.transform.position = new Vector3(_PlayerCurrentX, _PlayerCurrentY);
                yield return new WaitForSeconds(_MoveDelay);
            }
        }
    }
}
