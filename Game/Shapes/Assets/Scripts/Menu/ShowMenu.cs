using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenu : MonoBehaviour
{

	/// <summary>
	/// This script shows and hides a object. (in this case a Menu)
	/// </summary>

	public GameObject toggle_object;
	public bool toggle;

	// Use this for initialization
	public void Toggle()
	{
		toggle = !toggle;

		if (toggle)
		{
			toggle_object.SetActive(true);
		}
		else
		{
			toggle_object.SetActive(false);
		}
	}


	void Update()
	{

		if (toggle)
		{
			toggle_object.SetActive(true);
		}
		else
		{
			toggle_object.SetActive(false);
		}

	}
}
	
