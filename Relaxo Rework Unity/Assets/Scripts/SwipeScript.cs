using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SwipeScript : MonoBehaviour
{
	public TouchGesture.GestureSettings GestureSetting;
	private TouchGesture touch;

	Toggle homeScreenToggleRight;
	Toggle homeScreenToggleLeft;
	Toggle timeScreenToggle;
	Toggle sessionScreenToggleRight;
	Toggle sessionScreenToggleLeft;
	Toggle instructionsScreenToggle;
	Toggle settingsScreenToggle;
	Toggle profileScreenToggle;
	Toggle achievementsScreenToggle;
	Toggle statisticsScreenToggle;
	
	TouchGesture touchGesture;
	ActiveScreen activeScreen;

	void Start ()
	{
		activeScreen = GameObject.Find ("Main Camera").GetComponent<ActiveScreen> ();

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
			if (activeScreen.homeScreen)
			{
				homeScreenToggleRight = GameObject.Find ("Home Screen Toggle R").GetComponent<Toggle>();
				homeScreenToggleRight.isOn = true;
				homeScreenToggleRight.isOn = false;
			}
			if (activeScreen.settingsScreen)
			{
				settingsScreenToggle = GameObject.Find ("Settings Screen Toggle").GetComponent<Toggle>();
				sessionScreenToggleRight.isOn = true;
				sessionScreenToggleRight.isOn = false;
			}

			if (activeScreen.sessionScreen)
			{
				sessionScreenToggleRight = GameObject.Find ("Session Screen Toggle R").GetComponent<Toggle>();
				sessionScreenToggleRight.isOn = true;
				sessionScreenToggleRight.isOn = false;
			}
			
			if (activeScreen.instructionsScreen)
			{
				instructionsScreenToggle = GameObject.Find ("Instructions Screen Toggle").GetComponent<Toggle>();
				instructionsScreenToggle.isOn = true;
				instructionsScreenToggle.isOn = false;
			}
		},
		
		onLeftSwipe: () =>
		{
			if (activeScreen.profileScreen)
			{
				profileScreenToggle = GameObject.Find ("Profile Screen Toggle").GetComponent<Toggle>();
				profileScreenToggle.isOn = true;
				profileScreenToggle.isOn = false;
			}
			
			if (activeScreen.achievementsScreen)
			{
				achievementsScreenToggle = GameObject.Find ("Achievements Screen Toggle").GetComponent<Toggle>();
				achievementsScreenToggle.isOn = true;
				achievementsScreenToggle.isOn = false;
			}
			
			if (activeScreen.staticticsScreen)
			{
				statisticsScreenToggle = GameObject.Find ("Statistics Screen Toggle").GetComponent<Toggle>();
				statisticsScreenToggle.isOn = true;
				statisticsScreenToggle.isOn = false;
			}

			if (activeScreen.timeScreen)
			{
				timeScreenToggle = GameObject.Find ("Time Screen Toggle").GetComponent<Toggle>();
				timeScreenToggle.isOn = true;
				timeScreenToggle.isOn = false;
			}
			
			if (activeScreen.sessionScreen)
			{
				sessionScreenToggleLeft = GameObject.Find ("Session Screen Toggle L").GetComponent<Toggle>();
				sessionScreenToggleLeft.isOn = true;
				sessionScreenToggleLeft.isOn = false;
			}
		}
		));
	}
}