using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretDrawerMove : MonoBehaviour 
{
	public int Counter = 0;
	public GameObject test4;
	int x;
	public Animator anim;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) {
			if (test4.active == true) {
				if (x >= 0) {
					if (x % 2 == 0) {
						
						Counter++;
					}
				}
			}
		}
		if (Counter == 27) 
		{
			anim.Play ("SecretOpen");
		}
	}
}
