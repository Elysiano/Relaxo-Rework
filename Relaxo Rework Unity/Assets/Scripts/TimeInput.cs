using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeInput : MonoBehaviour
{
	GameObject hours;
	GameObject minutes;
	int inputHours;
	int inputMinutes;

	//Set GameObjects to variables & set the start time to 0 hours and 0 minutes
	void Start ()
	{
		hours = GameObject.Find ("Hours");
		minutes = GameObject.Find ("Minutes");

		inputHours = 0;
		inputMinutes = 0;
	}

	// Keep updating the playtime
	void Update ()
	{
		hours.GetComponent<Text> ().text = inputHours.ToString ();
		minutes.GetComponent<Text> ().text = inputMinutes.ToString ();
	}

	// Functions to + or - the playtime if an arrow is pressed
	public void PlusHours ()
	{
		if (inputHours < 4)
		{
			inputHours ++;
		}
		else
		{
			inputHours = 0;
		}

	}

	public void MinHours ()
	{
		if (inputHours > 0)
		{
			inputHours --;
		}
		else
		{
			inputHours = 4;
		}
	}

	public void PlusMinutes ()
	{
		if (inputMinutes < 59)
		{
			inputMinutes ++;
		}
		else
		{
			inputMinutes = 0;
		}
	}
	
	public void MinMinutes ()
	{
		if(inputMinutes > 0)
		{
			inputMinutes --;
		}
		else
		{
			inputMinutes = 59;
		}
	}

	// Go to the next slide
	public void NextSlide ()
	{

	}
}