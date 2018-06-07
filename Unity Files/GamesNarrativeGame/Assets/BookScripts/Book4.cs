﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book4 : MonoBehaviour
{
    Color m_MouseOverColor1 = Color.red;
    Color m_OriginalColor1;
    MeshRenderer m_Renderer1;
    public Animator anim;
    public int x = 0;
	public Moving other;
	public GameObject CBook5;
	public GameObject Updater;


    void OnMouseDown()
    {

        if (x % 2 == 0)
        {
            anim.Play("Book5");
			Updater.SetActive (false);
            StartCoroutine(False());

        }
        /*if (x % 2 == 1)
        {
            anim.Play("Book5Reverse");
            StartCoroutine(True());

        }*/


    }


    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        m_Renderer1 = GetComponent<MeshRenderer>();
        m_OriginalColor1 = m_Renderer1.material.color;
    }

    IEnumerator False()
    {
		
        yield return new WaitForSeconds(1);
        x++;
		yield return new WaitForSeconds(2);
		other.ShowMain2Camera();
		Updater.SetActive (true);
    }
    IEnumerator True()
    {
        yield return new WaitForSeconds(1);
        x++;
    }
    void OnMouseOver()
    {
        m_Renderer1.material.color = m_MouseOverColor1;
    }

    void OnMouseExit()
    {
        m_Renderer1.material.color = m_OriginalColor1;
    }
    // Update is called once per frame
    void Update()
    {
        if (x >= 2)
        {
            x = 0;
        }
		if (Input.GetMouseButtonDown (0)) 
		{
			if (CBook5.active == true) 
			{
				x = 1;
			}
			else 
			{
				x = 0;
			}
			if (x % 2 == 1)
			{
				if (x % 2 == 1) 
				{
					anim.Play ("Book5Reverse");
					StartCoroutine (True ());

				}
			}
		}
    }
}