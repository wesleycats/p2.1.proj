using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ShapeChange : MonoBehaviour {
	/// <summary>
	/// This class is used to look for input and if the buttons 1 - 4 are pressed.
	/// If so, it changes to the correct shape. That being sqaure, circel and triangle (more may come).
	/// </summary>

	[SerializeField]
	Sprite _Circle;
	[SerializeField]
	Sprite _Triangle;
	[SerializeField]
	Sprite _Square;

	public int _ShapeValue = 1;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("1"))
		{
			_ShapeValue = 1;
			gameObject.GetComponent<SpriteRenderer>().sprite = _Square;

		}

		if (Input.GetKeyDown("2"))
		{
			_ShapeValue = 2;
			gameObject.GetComponent<SpriteRenderer>().sprite = _Circle;


		}
	}
}
