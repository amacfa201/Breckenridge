using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    public Camera Main;
    public Camera Journals;
    public GameObject John;
    public GameObject Mary;
	public GameObject Luke;
	public GameObject Rowan;
	public GameObject Darwin;
	public GameObject Margaret;
	public GameObject MargaretSecret;
    public GameObject Button;
	public GameObject DarwinFile;
	public GameObject JohnFile;
	public GameObject MaryFile;
	public GameObject MargretFile;
	public GameObject LukeFile;
	public GameObject RowanFile;
	public GameObject Text;
	public GameObject SarahFile;
	public GameObject BkGrd;
    
   

    public void ShowMainCamera()
    {
        Main.enabled = false;
        Journals.enabled = true;
        John.SetActive(true);
        Button.SetActive(true);
		Text.SetActive (true);
		BkGrd.SetActive (true);

    }
    public void ShowJournalsCamera()
    {
        Main.enabled = true;
        Journals.enabled = false;
        Button.SetActive(false);
        John.SetActive(false);
        Mary.SetActive(false);
		Luke.SetActive(false);
		Rowan.SetActive(false);
		Darwin.SetActive(false);
		Margaret.SetActive(false);
		DarwinFile.SetActive (false);
		JohnFile.SetActive (false);
		MaryFile.SetActive (false);
		MargretFile.SetActive (false);
		MargaretSecret.SetActive (false);
		LukeFile.SetActive (false);
		RowanFile.SetActive (false);
		Text.SetActive (false);
		SarahFile.SetActive (false);
		BkGrd.SetActive (false);
    }
    public void ShowMain2Camera()
    {
        Main.enabled = false;
        Journals.enabled = true;
        Button.SetActive(true);
        Mary.SetActive(true);
		Text.SetActive (true);
		BkGrd.SetActive (true);
    }
	public void ShowMain3Camera()
	{
		Main.enabled = false;
		Journals.enabled = true;
		Button.SetActive(true);
		Luke.SetActive(true);
		Text.SetActive (true);
		BkGrd.SetActive (true);
	}
	public void ShowMain4Camera()
	{
		Main.enabled = false;
		Journals.enabled = true;
		Button.SetActive(true);
		Rowan.SetActive(true);
		Text.SetActive (true);
		BkGrd.SetActive (true);
	}
	public void ShowMain5Camera()
	{
		Main.enabled = false;
		Journals.enabled = true;
		Button.SetActive(true);
		Darwin.SetActive(true);
		Text.SetActive (true);
		BkGrd.SetActive (true);
	}
	public void ShowMain6Camera()
	{
		Main.enabled = false;
		Journals.enabled = true;
		Button.SetActive(true);
		Margaret.SetActive(true);
		Text.SetActive (true);
		BkGrd.SetActive (true);
	}
	public void ShowJohnFile()
	{
		Main.enabled = false;
		Journals.enabled = true;
		Button.SetActive(true);
		JohnFile.SetActive(true);
		BkGrd.SetActive (true);
	}
	public void ShowMaryFile()
	{
		Main.enabled = false;
		Journals.enabled = true;
		Button.SetActive(true);
		MaryFile.SetActive(true);	
		BkGrd.SetActive (true);
	}
	public void ShowLukeFile()
	{
		Main.enabled = false;
		Journals.enabled = true;
		Button.SetActive(true);
		LukeFile.SetActive(true);	
		BkGrd.SetActive (true);
	}
	public void ShowMargretFile()
	{
		Main.enabled = false;
		Journals.enabled = true;
		Button.SetActive(true);
		MargretFile.SetActive(true);	
		BkGrd.SetActive (true);
	}
	public void ShowRowanFile()
	{
		Main.enabled = false;
		Journals.enabled = true;
		Button.SetActive(true);
		RowanFile.SetActive(true);	
		BkGrd.SetActive (true);
	}
	public void ShowDarwinFile()
	{
		Main.enabled = false;
		Journals.enabled = true;
		Button.SetActive(true);
		DarwinFile.SetActive(true);	
		BkGrd.SetActive (true);
	}
	public void ShowSarahFile()
	{
		Main.enabled = false;
		Journals.enabled = true;
		Button.SetActive(true);
		SarahFile.SetActive(true);	
		BkGrd.SetActive (true);
	}
	public void ShowMargaretSecret()
	{
		Main.enabled = false;
		Journals.enabled = true;
		Button.SetActive (true);
		MargaretSecret.SetActive (true);
		BkGrd.SetActive (true);
	}
}
