using UnityEngine;
using System.Collections;

public class ActiveScreen : MonoBehaviour
{
	Camera camera;
	public bool homeScreen = false;
	public bool settingsScreen = false;
	public bool profileScreen = false;
	public bool achievementsScreen = false;
	public bool staticticsScreen = false;
	public bool timeScreen = false;
	public bool sessionScreen = false;
	public bool instructionsScreen = false;

	void Start ()
	{
		camera = GetComponent<Camera> ();
	}

	void Update ()
	{
		Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width * 0.5f,Screen.height * 0.5f, 0));
		RaycastHit hit;
		Debug.DrawRay (ray.origin, ray.direction * 500);

		if (Physics.Raycast(ray, out hit, 500))
		{
			if (hit.transform.tag == "HomeScreen")
			{
				homeScreen = true;
			}
			else
				homeScreen = false;

			if (hit.collider.tag == "SettingsScreen")
			{
				settingsScreen = true;
			}
			else
				settingsScreen = false;

			if (hit.collider.tag == "ProfileScreen")
			{
				profileScreen = true;
			}
			else
				profileScreen = false;

			if (hit.collider.tag == "AchievementsScreen")
			{
				achievementsScreen = true;
			}
			else
				achievementsScreen = false;

			if (hit.collider.tag == "StatisticsScreen")
			{
				staticticsScreen = true;
			}
			else
				staticticsScreen = false;

			if (hit.transform.tag == "TimeScreen")
			{
				timeScreen = true;
			}
			else
				timeScreen = false;

			if (hit.collider.tag == "SessionScreen")
			{
				sessionScreen = true;
			}
			else
				sessionScreen = false;

			if (hit.collider.tag == "InstructionsScreen")
			{
				instructionsScreen = true;
			}
			else
				instructionsScreen = false;
		}
	}
}