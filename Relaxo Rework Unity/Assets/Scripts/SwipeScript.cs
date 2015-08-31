using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SwipeScript : MonoBehaviour
{
	public TouchGesture.GestureSettings GestureSetting;
	private TouchGesture touch;

	Toggle homeScreenToggleRight;
	Toggle homeScreenToggleLeft;
	Toggle homeScreenToggleDown;
	Toggle timeScreenToggleLeft;
	Toggle timeScreenToggleUp;
	Toggle sessionScreenToggleRight;
	Toggle sessionScreenToggleLeft;
	Toggle instructionsScreenToggle;
	Toggle settingsScreenToggle;
	Toggle profileScreenToggleLeft;
	Toggle profileScreenToggleRight;
	Toggle achievementsScreenToggleLeft;
	Toggle achievementsScreenToggleRight;
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
			if (activeScreen.timeScreen)
			{
				timeScreenToggleUp = GameObject.Find ("Time Screen Toggle U").GetComponent<Toggle>();
				timeScreenToggleUp.isOn = true;
				timeScreenToggleUp.isOn = false;
			}
		},
		
		onUpSwipe: () =>
		{
			if (activeScreen.homeScreen)
			{
				homeScreenToggleDown = GameObject.Find ("Home Screen Toggle D").GetComponent<Toggle>();
				homeScreenToggleDown.isOn = true;
				homeScreenToggleDown.isOn = false;
			}
		},
		
		onRightSwipe: () =>
		{
			if (activeScreen.homeScreen)
			{
				homeScreenToggleRight = GameObject.Find ("Home Screen Toggle R").GetComponent<Toggle>();
				homeScreenToggleRight.isOn = true;
				homeScreenToggleRight.isOn = false;
			}

			if (activeScreen.profileScreen)
			{
				profileScreenToggleRight = GameObject.Find ("Profile Screen Toggle R").GetComponent<Toggle>();
				profileScreenToggleRight.isOn = true;
				profileScreenToggleRight.isOn = false;
			}

			if (activeScreen.achievementsScreen)
			{
				achievementsScreenToggleRight = GameObject.Find ("Achievements Screen Toggle R").GetComponent<Toggle>();
				achievementsScreenToggleRight.isOn = true;
				achievementsScreenToggleRight.isOn = false;
			}

			if (activeScreen.staticticsScreen)
			{
				statisticsScreenToggle = GameObject.Find ("Statistics Screen Toggle").GetComponent<Toggle>();
				statisticsScreenToggle.isOn = true;
				statisticsScreenToggle.isOn = false;
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
			if (activeScreen.homeScreen)
			{
				homeScreenToggleLeft = GameObject.Find ("Home Screen Toggle L").GetComponent<Toggle>();
				homeScreenToggleLeft.isOn = true;
				homeScreenToggleLeft.isOn = false;
			}

			if (activeScreen.settingsScreen)
			{
				settingsScreenToggle = GameObject.Find ("Settings Screen Toggle").GetComponent<Toggle>();
				settingsScreenToggle.isOn = true;
				settingsScreenToggle.isOn = false;
			}

			if (activeScreen.profileScreen)
			{
				profileScreenToggleLeft = GameObject.Find ("Profile Screen Toggle L").GetComponent<Toggle>();
				profileScreenToggleLeft.isOn = true;
				profileScreenToggleLeft.isOn = false;
			}
			
			if (activeScreen.achievementsScreen)
			{
				achievementsScreenToggleLeft = GameObject.Find ("Achievements Screen Toggle L").GetComponent<Toggle>();
				achievementsScreenToggleLeft.isOn = true;
				achievementsScreenToggleLeft.isOn = false;
			}

			if (activeScreen.timeScreen)
			{
				timeScreenToggleLeft = GameObject.Find ("Time Screen Toggle L").GetComponent<Toggle>();
				timeScreenToggleLeft.isOn = true;
				timeScreenToggleLeft.isOn = false;
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