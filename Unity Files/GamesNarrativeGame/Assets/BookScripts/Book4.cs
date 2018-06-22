using System.Collections;
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
    public bool bookOpening;


    void OnMouseDown()
    {

        if (x % 2 == 0 && !bookOpening)
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
        bookOpening = true;
        yield return new WaitForSeconds(1);
        x++;
		yield return new WaitForSeconds(1.95f);
		other.ShowMain2Camera();
		Updater.SetActive (true);
        yield return new WaitForSeconds(3f);
        bookOpening = false;
        //yield return null;
    }
    IEnumerator True()
    {
      
            x++;
            yield return null;
        
       
    }
    void OnMouseOver()
    {

        if (!bookOpening)
        {
            m_Renderer1.material.color = m_MouseOverColor1;
        }
      
        
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
                print("IN HERE");
            }
            if (Input.GetMouseButtonDown(0)  && !bookOpening)
            {
           
            if (CBook5.activeInHierarchy == true)
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
                    
                    anim.Play("Book5Reverse");
                        StartCoroutine(True());

                    }
                }
            }
        
    }
}