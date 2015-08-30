using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeInput : MonoBehaviour
{
	GameObject hours;
	GameObject minutes;
	GameObject touchHour;
	GameObject touchMinute;
	int inputHours;
	int inputMinutes;

	Toggle timeScreenToggle;
	Toggle sessionScreenToggleRight;
	Toggle sessionScreenToggleLeft;
	Toggle instructionsScreenToggle;

	public TouchGesture.GestureSettings GestureSetting;
	private TouchGesture touch;

	TouchGesture touchGesture;
	UIManager uiManager;

	//Set GameObjects to variables & set the start time to 0 hours and 0 minutes
	void Start ()
	{
		uiManager = GameObject.Find ("UIManager").GetComponent<UIManager> ();

		hours = GameObject.Find ("Hours");
		minutes = GameObject.Find ("Minutes");

		touchHour = GameObject.Find ("TouchHour");
		touchMinute = GameObject.Find ("TouchMinute");

		inputHours = 0;
		inputMinutes = 0;

		touch = new TouchGesture(this.GestureSetting);
		StartCoroutine(touch.CheckHorizontalSwipes(
		onDownSwipe: () =>
		{
			print ("Down");
		},

		onUpSwipe: () =>
		{
			print ("Up");
		},

		onRightSwipe: () =>
		{
			print ("Right");
			sessionScreenToggleRight = GameObject.Find ("Session Screen Toggle R").GetComponent<Toggle>();
			sessionScreenToggleRight.isOn = true;
			sessionScreenToggleRight.isOn = false;

			//instructionsScreenToggle = GameObject.Find ("Instructions Screen Toggle").GetComponent<Toggle>();
			//instructionsScreenToggle.isOn = true;
			//instructionsScreenToggle.isOn = false;
		},
		
		onLeftSwipe: () =>
		{
			print ("Left");
			timeScreenToggle = GameObject.Find ("Time Screen Toggle").GetComponent<Toggle>();
			timeScreenToggle.isOn = true;
			timeScreenToggle.isOn = false;

			//sessionScreenToggleLeft = GameObject.Find ("Session Screen Toggle L").GetComponent<Toggle>();
			//sessionScreenToggleLeft.isOn = true;
			//sessionScreenToggleLeft.isOn = false;
		}
		));
	}
	
	// Keep updating the playtime
	void Update ()
	{
		hours.GetComponent<Text> ().text = inputHours.ToString ();
		minutes.GetComponent<Text> ().text = inputMinutes.ToString ();
		//print (Input.mousePosition);
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
}