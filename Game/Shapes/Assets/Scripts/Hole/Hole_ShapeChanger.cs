using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole_ShapeChanger : MonoBehaviour
{

	/// <summary>
	/// This script determines the shape of a hole
	/// </summary>

	public int _WallValue = 1;
	[SerializeField]
	Sprite _Square;
	[SerializeField]
	Sprite _Triangle;
	[SerializeField]
	Sprite _Circle;



	// Use this for initialization
	void Start()
	{
		_WallValue = Random.Range(1, 3);
		//print(_WallValue);

		switch (_WallValue)
		{
			case 1:
				gameObject.GetComponent<SpriteRenderer>().sprite = _Square;
				break;

			case 2:
				gameObject.GetComponent<SpriteRenderer>().sprite = _Circle;
				break;

			case 3:
				gameObject.GetComponent<SpriteRenderer>().sprite = _Triangle;
				break;
		}
	}

	// Update is called once per frame
	void Update()
	{

	}
}

