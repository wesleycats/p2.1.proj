using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitSnenes : MonoBehaviour {

    /// <summary>
	/// This script Quits the game
	/// </summary>
    public void Quit()
    {

		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#else
        Application.Quit ();
		#endif
    }
}
