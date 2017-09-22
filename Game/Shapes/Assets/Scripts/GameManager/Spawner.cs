using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public float _WallSpawnTime;
    private float _Timer;
    private float _WallSpawnPosition;
    [SerializeField]
    private GameObject _Wall;

	// Use this for initialization
	void Start () {
        StartCoroutine("WallSpawnTime");
	}
	
	// Update is called once per frame
	void Update () {
        /*
        // Alternative spawntimer
        _Timer += Time.deltaTime;
        if (_Timer > _SpawnTime)
        {
            _Timer = 0;
            Debug.Log("SPAWN");
        }
        */
        _WallSpawnPosition = 11;//Random.Range(11, 30);
    }

    private IEnumerator WallSpawnTime()
    {
        while (true)
        {
            CreateWalls();
            yield return new WaitForSeconds(_WallSpawnTime);
        }
    }

    void CreateWalls()
    {
        Instantiate(_Wall, new Vector3(_WallSpawnPosition, transform.position.y), transform.rotation);
    }
}
