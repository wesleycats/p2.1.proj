using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole_ShapeChanger : MonoBehaviour
{
	public int _WallValue;
	[SerializeField]
	Sprite _Square;
	[SerializeField]
	Sprite _Triangle;
	[SerializeField]
	Sprite _Circle;

    Sprite[] sprites;
    public SpriteRenderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
        sprites = new Sprite[3];
        sprites[0] = _Square;
        sprites[1] = _Circle;
        sprites[2] = _Triangle;
    }

    // Use this for initialization
    void Start()
	{
		_WallValue = Random.Range(0, 3);
        _renderer.sprite = sprites[_WallValue];

        /*
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
        */
    }

	// Update is called once per frame
	void Update()
	{

	}
}

