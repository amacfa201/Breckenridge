using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Animator anim;
    public int f = 1;
    public int x = 0;
    public GameObject test;
    public GameObject test2;
    public GameObject test3;
	public GameObject test4;
    public GameObject Button;
	public int Counter = 0;



    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        GameObject test = gameObject;
    }

    IEnumerator False()
    {
        yield return new WaitForSeconds(2);
        x++;
		Counter++;
    }
    IEnumerator True()
    {
        yield return new WaitForSeconds(0);
        x++;
      
        
    }
    IEnumerator Ftrue()
    {
        yield return new WaitForSeconds(0);
        f++;

    }
    IEnumerator Ffalse()
    {
        yield return new WaitForSeconds(0);
        f++;
    }
  
    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown (0)) 
		{
			if (test4.active == false) 
			{
				if (x >= 0) 
				{
					if (x % 2 == 0)
					{
						anim.Play ("CameraReading");
						StartCoroutine (False ());
					}
				}
			}
			if (test4.active == true)
			{
				if (x >= 0) 
				{
					if (x % 2 == 1) 
					{
						anim.Play ("CameraNomal");
						StartCoroutine (True ());
					}
				}
			}
		}

        
        if (Button.active == true)
        {
            x = 1;
        }
        else
        {
            x = 0; 
        }
    if (x >= 2)
        {
            x = 0;
        }
    if (test.active == false)
        {
            f = 3;
        }
    if (test2.active == false)
        {
            f = 7;
        }
    if (test3.active == false)
        {
            f = 11;
        }
           if (Input.GetMouseButtonDown(0))
             {
             if (f >= 3)
                {
                if (f <= 6) 
                    {
                      if (f % 2 == 1)
                        {
                        anim.Play("Drawer1Read");
                        StartCoroutine(Ftrue());
                        }
                      if (f % 2 == 0)
                        {
                        anim.Play("Normal1");
                        StartCoroutine(Ffalse());
                        }
                    }
                }
            if (f >= 7)
            {
                if (f <= 10)
                {
                    if (f % 2 == 1)
                    {
                        anim.Play("Drawer2Read");
                        StartCoroutine(Ftrue());
                    }
                    if (f % 2 == 0)
                    {
                        anim.Play("Normal2");
                        StartCoroutine(Ffalse());
                    }
                }
            }
             if (f >= 11)
            {
                if (f%2 ==1)
                {
                    anim.Play("Drawer3Read");
                    StartCoroutine(Ftrue());
                }
                if (f % 2 == 0)
                {
                    anim.Play("Normal3");
                    StartCoroutine(Ffalse());
                }
            }
         }
           if (f == 5)
        {
            f = 0;
        }
        if (f == 9)

        {
            f = 0;
        }
        if ( f == 13)
        {
            f = 0;
        }

    }
}
