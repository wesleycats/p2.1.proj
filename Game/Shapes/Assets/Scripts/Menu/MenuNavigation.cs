using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuNavigation : MonoBehaviour {

	/// <summary>
	/// This script handels the navigation of the main menu
	/// </summary>


	enum Selected { Start, Options, Quit , Colors , Back, QuitGameOptions };
	Selected _Selected = Selected.Start;

	[SerializeField]
	Image _Start;
	[SerializeField]
	Image _Options;
	[SerializeField]
	Image _Quit;
	[SerializeField]
	Image _Back;
	[SerializeField]
	Image _Colors;
	[SerializeField]
	Image _QuitOptions;


	[SerializeField]
	GameObject toggle_object;
	public bool toggle;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update() {
		print(toggle);
		if (toggle)
		{
			toggle_object.SetActive(true);
		}
		else
		{
			toggle_object.SetActive(false);
		}

		_Start.color = new Color(1, 1, 1, 1);
		_Options.color = new Color(1, 1, 1, 1);
		_Quit.color = new Color(1, 1, 1, 1);
		_Back.color = new Color(1, 1, 1, 1);
		_Colors.color = new Color(1, 1, 1, 1);
		_QuitOptions.color = new Color(1, 1, 1, 1);

		CheckForInput();

		switch (_Selected)
		{
			case Selected.Start:
				_Start.color = new Color(1, 0, 0, 1);
				break;
			case Selected.Options:
				_Options.color = new Color(1, 0, 0, 1);
				break;
			case Selected.Quit:
				_Quit.color = new Color(1, 0, 0, 1);
				break;
			case Selected.Back:
				_Back.color = new Color(1, 0, 0, 1);
				break;
			case Selected.Colors:
				_Colors.color = new Color(1, 0, 0, 1);
				break;
			case Selected.QuitGameOptions:
				_QuitOptions.color = new Color(1, 0, 0, 1);
				break;

		}

		



	}


	//Quits the game
	public void Quit()
	{

	#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
	#else
        Application.Quit ();
	#endif
	}

	//Thoggles the options menu
	public void ToggleOptionMenu()
	{
		toggle = !toggle;

		if (toggle)
		{
			toggle_object.SetActive(true);
			_Selected = Selected.Colors;
		}
		else
		{
			toggle_object.SetActive(false);
			_Selected = Selected.Start;
		}

		
	}

	public void LoadScene(int sceneIndex)
	{
		SceneManager.LoadScene(sceneIndex);
	}

	void CheckForInput()
	{
		if (Input.GetKeyDown(KeyCode.W))
		{

			if (_Selected != Selected.Start && !toggle)
			{
				_Selected--;

			}
			else if (!toggle)
			{

				_Selected = Selected.Quit;
			}

			if (_Selected != Selected.Colors && toggle)
			{
				_Selected--;
			}
			else if (toggle)
			{
				_Selected = Selected.QuitGameOptions;
			}
		}

		if (Input.GetKeyDown(KeyCode.S))
		{
			if (_Selected != Selected.Quit && !toggle)
			{
				_Selected++;

			}
			else if (!toggle)
			{

				_Selected = Selected.Start;
			}

			if (_Selected != Selected.QuitGameOptions && toggle)
			{
				_Selected++;
			}
			else if (toggle)
			{
				_Selected = Selected.Colors;
			}
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{

			switch (_Selected)
			{
				case Selected.Start:
					LoadScene(1);
					break;
				case Selected.Options:
					ToggleOptionMenu();
					break;
				case Selected.Quit:
					Quit();
					break;
				case Selected.Back:
					ToggleOptionMenu();
					break;
				case Selected.Colors:
					//Quit();
					break;
				case Selected.QuitGameOptions:
					Quit();
					break;
			}
		}
	}
}




