using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMovement : MonoBehaviour {

    private float _BGCurrentX;
    private float _BackgroundX;
    [SerializeField]
    private float _MapSpeed;
    [SerializeField]
    private GameObject _Background;

    // Use this for initialization
    void Start () { 
        _BackgroundX = 25.1f;
        //_MapSpeed = 5;
    }
	
	// Update is called once per frame
	void Update () {
        CheckPosition();
        _BGCurrentX = this.transform.position.x;

        transform.position += new Vector3(-_MapSpeed * Time.fixedDeltaTime, 0.0f, 0.0f);
	}

    void CheckPosition()
    {
        if (_BGCurrentX <= -_BackgroundX)
        {
            //Debug.Log("BG");
            //Instantiate(_Background, new Vector3(_BackgroundX, transform.position.y), transform.rotation);
            //Destroy(gameObject);

            transform.position = new Vector3(_BackgroundX, transform.position.y);
        }
    }
}
