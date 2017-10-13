using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
<<<<<<< HEAD
    private GameObject _GM;
    private float _WallSpeed;
=======
    [SerializeField]
    private float _MapSpeed;
>>>>>>> 2e8b70eadeec5b197e6da144e1172807c8c8dbcd

    // Use this for initialization
    void Start()
    {
<<<<<<< HEAD
        _GM = GameObject.Find("GameManager");
=======
        //_MapSpeed = 5;
>>>>>>> 2e8b70eadeec5b197e6da144e1172807c8c8dbcd
    }

    // Update is called once per frame
    void Update()
    {
        CheckPosition();
<<<<<<< HEAD
        _WallSpeed = _GM.GetComponent<Difficulty>()._WallSpeed;
        transform.position += new Vector3(-_WallSpeed * Time.deltaTime, 0.0f, 0.0f);
=======
        transform.position += new Vector3(-_MapSpeed * Time.deltaTime, 0.0f, 0.0f);
>>>>>>> 2e8b70eadeec5b197e6da144e1172807c8c8dbcd
    }

    void CheckPosition()
    {
        if (transform.position.x <= -20)
        {
            Destroy(gameObject);
        }
    }
}
