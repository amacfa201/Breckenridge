using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour 
{

	// Loads scene1 (change name as apropreate).
	public void MainScene () 
	{
		SceneManager.LoadScene ("demo 2");
	}

	// Loads scene2.
	public void MenuScene () 
	{
		SceneManager.LoadScene ("MenuScene");
	}
		
	// Loads scene2.
	public void OptionsScene () 
	{
		SceneManager.LoadScene ("OptionScene");
	}

	// Quits the game.
	public void Quit ()
	{
		Application.Quit ();
	}
}
