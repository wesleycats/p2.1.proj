using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player_Handeler : MonoBehaviour {

	/// <summary>
	/// This class is used for handeling the life and score of the player.
	/// </summary>

	public int _Score = 0;
	public int _Lives = 5;
	bool _Shielding = false;
	[SerializeField]
	Text _LivesText;
	[SerializeField]
	Text _ScoreText;
    new AudioSource audio;



    // Use this for initialization
    void Start () {
        print("Lives are: " + _Lives);
        print("Score is: " + _Score);
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		_ScoreText.text = "Score: " + _Score;
		_LivesText.text = "Lives: " + _Lives;
        CheckLives();
	}


	//This OnCollisionEnter is used to look if it is touching a wall and if so, it compairs the players wallvalue with the wall's wallvalue.
	//If it is the same then it wil destroy the wall and adds 100 to the score. Else it wil detract 50 from the score, the wall will be destroyed and the player loses a life


	void OnTriggerEnter2D(Collider2D coll)
	{
        if (_Shielding == false)
        {
            if (coll.gameObject.tag == "Hole")
            {
                //if (coll.gameObject.GetComponent<Hole_ShapeChanger>()._WallValue == gameObject.GetComponent<Player_ShapeChange>()._ShapeValue)
                if (coll.gameObject.GetComponent<Hole_ShapeChanger>()._renderer.sprite == gameObject.GetComponent<Player_ShapeChange>()._renderer.sprite)
                {
                    StartCoroutine("Shield");
                    _Score += 100;
                }
                else
                {
                    StartCoroutine("Shield");
                    _Lives -= 1;
                    audio.Play();
                }
            }

            if (_Shielding == false)
            {
                StartCoroutine("Shield");
                _Lives -= 1;
                audio.Play();
            }
        }
    }

	private IEnumerator Shield()
	{
        while (!_Shielding)
        {
            _Shielding = true;
            yield return new WaitForSeconds(0.5f);
        }
        _Shielding = false;
	}

    void CheckLives()
    {
        if (_Lives <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }

}

