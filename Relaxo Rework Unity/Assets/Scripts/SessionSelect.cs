using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SessionSelect : MonoBehaviour
{
	Color selectedColor = new Color (0.796f, 0.709f, 0.392f, 1f);
	Color sessionColor = new Color (0.49f, 0.49f, 0.49f, 1f);

	bool hitSession = false;
	bool casting = false;

	void Start ()
	{
	
	}

	void Update ()
	{
		Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width * 0.5f, (Screen.height * 0.5f + 100), 0));
		RaycastHit hit;
		Debug.DrawRay (ray.origin, ray.direction * 500, Color.blue);

		if (Physics.Raycast (ray, out hit, 500))
		{
			if (hit.collider.tag == "Session")
			{
				hitSession = true;
				casting = true;
			}
		}
		else
		{
			hitSession = false;
		}

		if (hitSession)
		{
			hit.collider.gameObject.GetComponent<Image> ().color = selectedColor;
			//hit.collider.transform.localScale = new Vector3 (1f, 1f, 1f);
			hit.collider.tag = "SelectedSession";
		}

		if (!hitSession)
		{
			if (casting)
			{
				GameObject.FindWithTag ("SelectedSession").GetComponent<Image> ().color = sessionColor;
				//GameObject.FindWithTag ("SelectedSession").transform.localScale = new Vector3 (0.8f, 0.8f, 1f);
				GameObject.FindWithTag ("SelectedSession").tag = "Session";
				casting = false;
			}
		}

		Ray ray2 = Camera.main.ScreenPointToRay(new Vector3(Screen.width * 0.5f, (Screen.height * 0.5f + 365), 0));
		//Ray ray2 = Camera.main.ScreenPointToRay(new Vector3(Screen.width * 0.5f, (Screen.height * 0.75f + 100), 0));
		RaycastHit hit2;
		Debug.DrawRay (ray2.origin, ray2.direction * 500, Color.green);

		if (Physics.Raycast (ray2, out hit2, 500))
		{
			if (hit2.collider.tag == "Session")
			{
				//hit2.collider.transform.localPosition = new Vector3 (0,900,0);
			}
		}

		Ray ray3 = Camera.main.ScreenPointToRay(new Vector3(Screen.width * 0.5f, (Screen.height * 0.5f - 183), 0));
		RaycastHit hit3;
		Debug.DrawRay (ray3.origin, ray3.direction * 500, Color.red);

		if (Physics.Raycast (ray3, out hit3, 500))
		{
			if (hit3.collider.tag == "Session")
			{
				//hit3.collider.transform.localPosition = new Vector3 (0,-900,0);
			}
		}
	}
}