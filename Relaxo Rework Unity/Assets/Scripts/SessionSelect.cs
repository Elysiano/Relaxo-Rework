using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SessionSelect : MonoBehaviour
{
	Color selectedColor = new Color (0.796f, 0.709f, 0.392f, 1f);
	Color unselectedColor = new Color (0.49f, 0.49f, 0.49f, 1f);

	void Start ()
	{
	
	}

	void Update ()
	{
		Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width * 0.5f, (Screen.height * 0.5f + 100), 0));
		RaycastHit hit;
		Debug.DrawRay (ray.origin, ray.direction * 500, Color.blue);

		if (Physics.Raycast(ray, out hit, 500))
		{
			if (hit.collider.tag == "SelectedSession")
			{
				GameObject.FindWithTag ("SelectedSession").GetComponent<Image> ().color = selectedColor;
				print ("Ik raak het actieve shitje");
			}
		}
	}

	void SelectSession ()
	{

	}
}
