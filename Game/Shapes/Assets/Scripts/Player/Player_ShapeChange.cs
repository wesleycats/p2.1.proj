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

    public SpriteRenderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Q))
		{
            _renderer.sprite = _Square;
			//gameObject.GetComponent<SpriteRenderer>().sprite = _Square;
		}

		if (Input.GetKeyDown(KeyCode.W))
		{
            _renderer.sprite = _Circle;
            //	gameObject.GetComponent<SpriteRenderer>().sprite = _Circle;
        }

        if (Input.GetKeyDown(KeyCode.E))
        { 
            _renderer.sprite = _Triangle;
            //   gameObject.GetComponent<SpriteRenderer>().sprite = _Triangle;
        }
    }
}
