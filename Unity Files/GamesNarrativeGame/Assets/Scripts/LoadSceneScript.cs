using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour 
{

	// Loads main game scene.
	public void LoadMainScene () 
	{
		SceneManager.LoadScene ("demo 2");
	}


	// Loads main menu scene.
	public void LoadMenuScene () 
	{
		SceneManager.LoadScene ("MenuScene");
	}


	// Loads options scene.
	public void LoadOptionsScene () 
	{
		SceneManager.LoadScene ("OptionsScene");
	}


	// Quits the game.
	public void Quit ()
	{
		Application.Quit ();
	}
}
