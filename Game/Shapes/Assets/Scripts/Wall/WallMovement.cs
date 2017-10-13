using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    private GameObject _GM;
    private float _WallSpeed;

    // Use this for initialization
    void Start()
    {
        _GM = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        CheckPosition();
        _WallSpeed = _GM.GetComponent<Difficulty>()._WallSpeed;
        transform.position += new Vector3(-_WallSpeed * Time.deltaTime, 0.0f, 0.0f);
    }

    void CheckPosition()
    {
        if (transform.position.x <= -20)
        {
            Destroy(gameObject);
        }
    }
}
