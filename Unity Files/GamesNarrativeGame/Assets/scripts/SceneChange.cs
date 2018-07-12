using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {
	public string loadscene;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (FadeScene ());
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	IEnumerator FadeScene()
	{
		yield return new WaitForSeconds (11);
		SceneManager.LoadScene (loadscene);
			
	}

}
