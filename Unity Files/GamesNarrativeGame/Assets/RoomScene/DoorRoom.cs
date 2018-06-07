using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRoom : MonoBehaviour {

    public Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(Play());
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
     IEnumerator Play()
    {
        yield return new WaitForSeconds(8);
        anim.Play("DoorOpen");
    }
}
