using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LukeFileScript : MonoBehaviour {
	public Animator anim;
	Color m_MouseOverColor1 = Color.red;
	Color m_OriginalColor1;
	MeshRenderer m_Renderer1;
	public Moving other;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
		m_Renderer1 = GetComponent<MeshRenderer>();
		m_OriginalColor1 = m_Renderer1.material.color;
	}

	// Update is called once per frame
	void OnMouseDown()
	{
		other.ShowLukeFile ();
	}
	void OnMouseOver()
	{
		m_Renderer1.material.color = m_MouseOverColor1;
	}
	void OnMouseExit()
	{
		m_Renderer1.material.color = m_OriginalColor1;
	}
	void Update () {

	}
}
