using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (FadeScene ());
	}


	// Waits specified amount of seconds then loads main menu scene.
	IEnumerator FadeScene()
	{
		yield return new WaitForSeconds (10);
		SceneManager.LoadScene ("MenuScene");
	}
}
