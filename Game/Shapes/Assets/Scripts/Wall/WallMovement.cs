using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    [SerializeField]
    private float _MapSpeed;

    // Use this for initialization
    void Start()
    {
        //_MapSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        CheckPosition();
        transform.position += new Vector3(-_MapSpeed * Time.deltaTime, 0.0f, 0.0f);
    }

    void CheckPosition()
    {
        if (transform.position.x >= 25.1f)
        {
            Destroy(gameObject);
        }
    }
}
