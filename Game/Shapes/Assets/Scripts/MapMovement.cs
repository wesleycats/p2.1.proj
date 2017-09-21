using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMovement : MonoBehaviour {

    private float _MapCurrentX;
    public float _MapSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(-_MapSpeed * Time.deltaTime, 0.0f, 0.0f);
	}
}
