using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MargaretSecretScript : MonoBehaviour {
	

	Color m_MouseOverColor1 = Color.red;
	Color m_OriginalColor1;
	MeshRenderer m_Renderer1;
	public Moving other;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnMouseDown()
	{
		other.ShowMargaretSecret ();
	}

	void OnMouseOver()
	{
		m_Renderer1.material.color = m_MouseOverColor1;
	}
	void OnMouseExit()
	{
		m_Renderer1.material.color = m_OriginalColor1;
	}

}
