using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Animator anim; // Again animator is set here but has nothing attatched but is called later with a GetComponent
    public int f = 1; // Both don't need to be public
    public int x = 0;
    public GameObject test; // Test 1-3 (other than being horribly named) are box colliders in the game but are set apart
                            //form everything else and don;t seem to do anything
    public GameObject test2;
    public GameObject test3;
    public GameObject test4; // This is linked to the updater that was used in the 'Book1' script and 'MargaretFileScript' script
    public GameObject Button;
    public int Counter = 0; // This is used by the SecretDrawerMove script and is used to reveal the book after a specific 
                            // number books and files are clicked on in the game (not needed anymore)

    public GameObject leftAnchor;
    public GameObject centreAnchor;
    public GameObject camera;
    public bool anyBooksOpen;
    public string sideAnimName;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        GameObject test = gameObject;
    }


    // Update is called once per frame
    void Update()
    {
        //Better to just animate the camera moving to the side probably wont use this code
        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    CameraLeft();
        //    print("IN" + this.gameObject);
        //    //transform.RotateAround(transform.position, Vector3.up, 10 * Time.deltaTime);
        //    //transform.eulerAngles = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y + 90,transform.eulerAngles.z);
        //    //camera.gameObject.transform.position = new Vector3(transform.position.x, 50, transform.position.z);
        //}


        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            anim.Play(sideAnimName);

        }
        

        if (Input.GetMouseButtonDown(0))
        {
            // Depends on if the updater gameobject is set to active or not in the 'Book1' (or other book/doc) script
            if (test4.active == false)
            {
                // Could be combined with one bellow if this 'if' is even necassery as it only checks to
                // to see it it's a negative but rest of the program is only ++ with no --
                if (x >= 0)
                {
                    // If 'x' is 2 or 0 plays animation and starts couroutine 'False' (can be 2 here because reset 
                    // to 0 is lower down unlike in 'Book1' script)
                    if (x % 2 == 0 )
                    {
                        // Sets it so that after the player clicks on a book the correct aniamtions will play and 
                        // the view will change to show the UI so they can read the book
                        anim.Play("CameraReading");
                        StartCoroutine(False());
                    }
                }
            }

            if (test4.active == true)
            {
                // Same here with the checking if 'x' is negative
                if (x >= 0)
                {
                    // If 'x' is 1 plays animation and starts couroutine 'True'
                    if (x % 2 == 1)
                    {
                        anim.Play("CameraNomal");
                        StartCoroutine(True());
                    }
                }
            }
        }


        // Set's value of 'x' depending on if the UI button used to exit the UI version of the book is active or not
        if (Button.active == true)
        {
            x = 1;
        }
        else
        {
            x = 0;
        }


        // Set's 'x' back to 0 if it gets bigger than or equal to 2 (so again boolean?)(also could be put at the start of Update)
        if (x >= 2)
        {
            x = 0;
        }


        // This 'f' stuff is all to do with the filing cabinets
        // These are set active or inactive in the appropreate drawer script ('test' is set in the 'Drawer1Script' script)
        if (test.active == false)
        {
            f = 3;
        }

        // The middle drawer dosen't have a script to activate it (this is just set up so it can be opened in the future?)
        if (test2.active == false)
        {
            f = 7;
        }

        // The bottom drawer dosen't have a script to activate it (other than the 'SecretDrawerMove' script)(this is just set up so it can be opened in the future?)
        if (test3.active == false)
        {
            f = 11;
        }


        if (Input.GetMouseButtonDown(0))
        {
            // This is used to make the camera move if the player clicks on the top draw of the filing cabinet
            if (f >= 3)
            {
                if (f <= 6)
                {
                    // Basically is 'f' is 3 or 5 this will run (exept 5 is reset to 0 later so can't be 5)(fuck)
                    if (f % 2 == 1)
                    {
                        anim.Play("Drawer1Read");
                        StartCoroutine(Ftrue());
                    }

                    // Else if 'f' is 4 this will run
                    if (f % 2 == 0)
                    {
                        anim.Play("Normal1");
                        StartCoroutine(Ffalse());
                    }
                }
            }

            // This is used to make the camera move if the player clicks on the middle draw of the filing cabinet
            if (f >= 7)
            {
                if (f <= 10)
                {
                    // If 'f' is 7 this will run
                    if (f % 2 == 1)
                    {
                        anim.Play("Drawer2Read");
                        StartCoroutine(Ftrue());
                    }

                    // If 'f' is 8 this will run
                    if (f % 2 == 0)
                    {
                        anim.Play("Normal2");
                        StartCoroutine(Ffalse());
                    }
                }
            }


            // This is used to make the camera move if the player clicks on the bottom draw of the filing cabinet
            if (f >= 11)
            {
                // If 'f' is 11 this will run
                if (f % 2 == 1)
                {
                    anim.Play("Drawer3Read");
                    StartCoroutine(Ftrue());
                }

                // If 'f' is 12 this will run
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


        if (f == 13)
        {
            f = 0;
        }

    }


    IEnumerator False()
    {
        // Waits for animation to play
        yield return new WaitForSeconds(2);
        // Makes 'x' equal 3 (which is reset to 0 in Update)
        x++;
        Counter++;
    }


    IEnumerator True()
    {
        yield return new WaitForSeconds(0); // WaitForSeconds could be taken out
                                            // Makes 'x' equal 2
        x++;
    }


    IEnumerator Ftrue()
    {
        yield return new WaitForSeconds(0); // Wait could be taken out
        f++;
    }


    IEnumerator Ffalse()
    {
        yield return new WaitForSeconds(0); // Wait could be taken out
        f++;
    }

  

}
