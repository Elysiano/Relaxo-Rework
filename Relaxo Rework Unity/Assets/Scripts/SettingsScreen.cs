using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingsScreen : MonoBehaviour {

	public float opacity;
	public static bool dutch;
	public static bool english;
	public static bool german;

	// Use this for initialization
	void Start () 
	{

		// The Opacity is the alpha channel, (worth/255) = Percentage
		opacity = (80f/255f);
	}
	
	// Update is called once per frame
	void Update () 
	{

		// The RawImage on the gameobject gets a new color, to be changed when clicked

		if (this.tag != "Language") 
		{
			GetComponent<RawImage> ().color = new Color (1f, 1f, 1f, opacity);
		}




	}


	// Changing the Language and disabling the other languages
	public void Dutch ()
	{
		dutch = true;
		german = false;
		english = false;
		opacity = 1f;

	}
	public void English ()
	{
		dutch = false;
		german = false;
		english = true;
        opacity = 1f;

	}
	public void German ()
	{
		dutch = false;
		german = true;
		english = false;
		opacity = 1f;

	}

}

//
//		if (german)
//		{
//			
//			if (gameObject.name =="German Flag")
//			{
//				opacity = 1f;
//			}
//			
//		} else
//		{
//			opacity = (80f/255f);
//		}
//
//		if (dutch)
//		{
//
//			if (gameObject.name =="Dutch Flag")
//			{
//				opacity = 1f;
//			}
//
//		} else
//		{
//			opacity = (80f/255f);
//		}
//
//		if (english)
//		{
//
//			if (gameObject.name =="UK Flag")
//			{
//				opacity = 1f;
//			}
//			
//		} else
//		{
//			//opacity = (80f/255f);
//		}
