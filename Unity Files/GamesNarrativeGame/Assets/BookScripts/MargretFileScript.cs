using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MargretFileScript : MonoBehaviour 
{
	public Animator anim; // Again not connected just called later
	Color m_MouseOverColor1 = Color.red;
	Color m_OriginalColor1;
	MeshRenderer m_Renderer1;
	public Moving other; // Set's button that activates when the UI part of the book is active and allows the player 
						 // to exit from the UI back to the rest of the game (but isn't called at any point??)

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
		m_Renderer1 = GetComponent<MeshRenderer>();
		m_OriginalColor1 = m_Renderer1.material.color;
	}


	void OnMouseDown()
	{
		// shows Margaret's file?
		other.ShowMargretFile ();
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
