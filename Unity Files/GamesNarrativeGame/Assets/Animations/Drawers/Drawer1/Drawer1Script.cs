using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer1Script : MonoBehaviour 
{
	public Animator anim; // Again not connected just called later
    public bool x = true; // Now we're using boolens thank fuck
    Color m_OriginalColor;
    Color m_MouseOverColor = Color.red;
    MeshRenderer m_Renderer;
    public GameObject test;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
        m_Renderer = GetComponent<MeshRenderer>();
        m_OriginalColor = m_Renderer.material.color;
	}


     void OnMouseDown()
    {
		// If 'x' is true (e.g. the drawer is closed) this runs
		if (x == true)
        {
			// This opens the drawer
            anim.Play("Drawer1Open");
			//Do we even need these coroutines? (Just shove the stuff from it in here)
            StartCoroutine(False());
            test.SetActive(false);
                     
        } 

		// If 'x' is false (e.g. the drawer is open) this runs
		if (x == false)
        {
			// This closes the drawer
            anim.Play("Drawer1Close");
            StartCoroutine(True());
        }
    }


	IEnumerator False()
	{
		// Again don't need WaitForSeconds
		yield return new WaitForSeconds(0);
		x = false;
		// This affects the state of 'f' in the 'CameraScript' script
		test.SetActive(true);
	}


	IEnumerator True()
	{
		yield return new WaitForSeconds(0);
		x = true;
	}


	// Changes mouse colour to chosen colour on mouse over
     void OnMouseOver()
    {
        m_Renderer.material.color = m_MouseOverColor;
    }
	// Changes mouse colour back to default color when mouse over ends
     void OnMouseExit()
    {
        m_Renderer.material.color = m_OriginalColor;
    }
}
