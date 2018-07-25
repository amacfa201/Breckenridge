using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book1 : MonoBehaviour
{
	// NOTE: this isn't attatched to Mary's book in the 'wallanddesk2' part of the hierarchy it is attatched to Margaret's book


	Color m_MouseOverColor1 = Color.red;
    Color m_OriginalColor1;
    MeshRenderer m_Renderer1;
	public Animator anim; // Animator is set here but dosen't have anything in the box but is set later with a GetComponent
	private int x = 0;
	public Moving other; // Set's button that activates when the UI part of the book is active and allows the player 
						 // to exit from the UI back to the rest of the game (but isn't called at any point??)
	public GameObject MaryBook; // Actually Margaret's book UI is set here
	public GameObject Updater; // This is a game object but the object is empty and is effectively a boolian used in 'CameraScript'



    void Start()
    {
        anim = GetComponent<Animator>();
        m_Renderer1 = GetComponent<MeshRenderer>();
        m_OriginalColor1 = m_Renderer1.material.color;
    }


    void Update()
    {
		// If 'x' is bigger than or equal to 2 then 'x' is reset to 0 (therfore 'x' can never be 2 or more) 
		// (I'm pretty sure this whole 'x' bit could be done with a boolean instead but not sure)
        if (x >= 2)
        {
            x = 0;
        }

		// On button click depending on the state of 'x' several things could occur
        if (Input.GetMouseButtonDown(0))
        {
			// If the object 'MaryBook' (the UI showing Margaret's journal) is set to be active then 'x' is set to 1
			if (MaryBook.active == true) 
			{
				x = 1;
			}
			// Else if 'MaryBook' is not active 'x' is set to 0
			else 
			{
				x = 0;
			}

			// If the remainder of 'x' devided by 2 is equal to 1 (  x-(x/2)*2= 1  (for (x/2) drop the number down if 
			// it isn't whole (eg. 0.5 becomes 0))) then the reverse of the book aniamtion is played and the 'True' 
			// coroutine is started (therefore 'x' is 1 at ths point) (Could this be simplified to be just x==1 )
            if (x % 2 == 1)
            {
                anim.Play("Book3Reverse");
                StartCoroutine(True());

            }
        }
    }


	void OnMouseDown()
	{
		// When the mouse is clicked, if the remainder of 'x' devided by 2 is equal to 0, then animation is played and 
		// the 'False' coroutine is started (Could this be in 'Update'?) (therfore 'x' is 0 at this point)
		if (x % 2 == 0)
		{
			anim.Play("Book3");
			Updater.SetActive (false);
			StartCoroutine(False());

		}
		// I didn't comment this out, think it's just old code
		/*if (x % 2 == 1)
        {
            anim.Play("Book2Reverse");
            StartCoroutine(True());

        }*/
	}


	IEnumerator False()
	{
		// Once book has been clicked on wait's for 1 second
		yield return new WaitForSeconds(1);
		// Increases 'x' by 1 (therefore 'x' is 1 at this point)
		x++;
		// Waits for 2 seconds (these allow time for the animation to play)
		yield return new WaitForSeconds(2);
		// Changes camera to the one outside the office area that shows the book UI
		other.ShowMain6Camera();
		Updater.SetActive (true);
	}


	IEnumerator True()
	{
		// Wait for 1 second and then increse 'x' by 1 (makes it 2 at this point) (which put's it back to 0 in Update ^^^)
		yield return new WaitForSeconds(1);
		x++;
	}


	// Changes mouse colour to chosen colour on mouse over
	void OnMouseOver()
	{
		m_Renderer1.material.color = m_MouseOverColor1;
	}
	// Changes mouse colour back to default color when mouse over ends
	void OnMouseExit()
	{
		m_Renderer1.material.color = m_OriginalColor1;
	}
}
