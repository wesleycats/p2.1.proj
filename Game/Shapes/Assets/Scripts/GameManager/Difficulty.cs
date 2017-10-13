using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is for increasing the difficulty of the game relative to the score of the player.
public class Difficulty : MonoBehaviour {

    private GameObject _Player;
    private GameObject _Wall;
    public float _WallSpeed;
    private int _Score;
    public float _WallSpawnTime;

    public float delay = 5;
    private float delayTimer;

    // Use this for initialization
    void Start () {
        _Player = GameObject.Find("Player");
        _WallSpawnTime = 3;
        _WallSpeed = 3.5f;
        delayTimer = delay;
    }
	
	// Update is called once per frame
	void Update () {
        delayTimer -= Time.deltaTime;
        _Score = _Player.GetComponent<Player_Handeler>()._Score;
        IncreaseScore();
    }

    void IncreaseScore()
    {
        if (_Score != 0 && _Score % 100 == 0 && delayTimer <= 0)
        {
            IncreaseWallSpeed();
            DecreaseSpawnTime();
            delayTimer = delay;
        }

        /*if (_Score != 0 && _Score % 500 == 0 && delayTimer <= 0)
        {
            DecreaseSpawnTime();
            delayTimer = delay;
        }*/
    }

    void IncreaseWallSpeed()
    {
        if (_WallSpeed >= 10)
        {
            _WallSpeed = 10;
        }
        else
        {
            _WallSpeed += 1f;
        }
    }

    void DecreaseSpawnTime()
    {
        if (_WallSpawnTime <= 1.5f)
        {
            _WallSpawnTime = 1.5f;
        }
        else
        {
            _WallSpawnTime -= 0.5f;
        }
    }
}
