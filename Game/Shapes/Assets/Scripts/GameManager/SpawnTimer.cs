using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTimer : MonoBehaviour {
    public float _SpawnTime;
    private float _Timer;
    private float _RealTime;

	// Use this for initialization
	void Start () {
        _SpawnTime = 3f;
        _RealTime = Time.realtimeSinceStartup;
	}
	
	// Update is called once per frame
	void Update () {
        _Timer += Time.deltaTime;
	}
}
