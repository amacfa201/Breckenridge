using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretDrawerMove : MonoBehaviour 
{
	// This script is attatched to room4/filing cabinet/Box003
	// NOTE: this is not really needed anymore

	public int Counter = 0;
	public GameObject test4; // Connected to the Updater gameobject
	int x;
	public Animator anim; // Again not connected just called later

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		// If the mouse is clicked on anything and the Updater is active (e.g. player is looking at 
		// the books or documents) and 'x' is even then the counter will increase by 1
		if (Input.GetMouseButtonDown (0)) 
		{
			if (test4.active == true) 
			{
				if (x >= 0) 
				{
					// If 'x' is an even number
					if (x % 2 == 0) 
					{
						Counter++;
					}
				}
			}
		}

		// When counter reaches 27 the secret book is revealed
		if (Counter == 27) 
		{
			anim.Play ("SecretOpen");
		}
	}
}
