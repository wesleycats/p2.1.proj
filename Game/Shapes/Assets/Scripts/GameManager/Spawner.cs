using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    private int _Random;
    public float _WallSpawnTime;
    private float _Timer;
    private float _WallSpawnPosition;
    [SerializeField]
    private GameObject _Wall;
    private float _HoleNumber;
    private float _HoleLocation;
    [SerializeField]
    private GameObject _Hole;
    

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
        _WallSpawnPosition = 11; //Random.Range(11, 30);
        _Random = Random.Range(1, 6);
    }

    private IEnumerator WallSpawnTime()
    {
        while (true)
        {
            CreateWalls();
            CreateHoles();
            yield return new WaitForSeconds(_WallSpawnTime);
        }
    }

    void CreateWalls()
    {
        Instantiate(_Wall, new Vector3(_WallSpawnPosition, transform.position.y), transform.rotation);
    }

    void CreateHoles()
    {
        switch (_Random)
        {
            case 1:
                {
                    Instantiate(_Hole, new Vector3(_WallSpawnPosition, 4.4f), transform.rotation);
                }
                break;

            case 2:
                {
                    Instantiate(_Hole, new Vector3(_WallSpawnPosition, 2.2f), transform.rotation);
                }
                break;

            case 3:
                {
                    Instantiate(_Hole, new Vector3(_WallSpawnPosition, transform.position.y), transform.rotation);
                }
                break;

            case 4:
                {
                    Instantiate(_Hole, new Vector3(_WallSpawnPosition, -2.2f), transform.rotation);
                }
                break;

            case 5:
                {
                    Instantiate(_Hole, new Vector3(_WallSpawnPosition, -4.4f), transform.rotation);
                }
                break;

            default:
                break;
        }
    }
}
