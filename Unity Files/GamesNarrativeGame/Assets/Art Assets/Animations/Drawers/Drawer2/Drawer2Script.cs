using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer2Script : MonoBehaviour {
    public Animator anim;
    public bool x = true;
    Color m_OriginalColor;
    Color m_MouseOverColor = Color.red;
    MeshRenderer m_Renderer;
    public GameObject test2;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
        m_Renderer = GetComponent<MeshRenderer>();
        m_OriginalColor = m_Renderer.material.color;
	}
    IEnumerator False()
    {
        yield return new WaitForSeconds(0);
        x = false;
        test2.SetActive(true);
    }
    IEnumerator True()
    {
        yield return new WaitForSeconds(0);
        x = true;
    }
    // Update is called once per frame
    void Update ()
    {
		
	}

     void OnMouseDown()
    {
        if (x==true)
        {
            anim.Play("Drawer2Open");
            StartCoroutine(False());
            test2.SetActive(false);
        }
        else
        {
            anim.Play("Drawer2Close");
            StartCoroutine(True());
        }
    }

    void OnMouseOver()
    {
        m_Renderer.material.color = m_MouseOverColor;
    }
    private void OnMouseExit()
    {
        m_Renderer.material.color = m_OriginalColor;
    }
}
