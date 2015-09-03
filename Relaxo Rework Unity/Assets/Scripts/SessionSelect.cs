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
			hit.collider.transform.localScale = new Vector3 (1f, 1f, 1f);
			hit.collider.tag = "SelectedSession";
		}

		if (!hitSession)
		{
			if (casting)
			{
				GameObject.FindWithTag ("SelectedSession").GetComponent<Image> ().color = sessionColor;
				GameObject.FindWithTag ("SelectedSession").transform.localScale = new Vector3 (0.8f, 0.8f, 1f);
				GameObject.FindWithTag ("SelectedSession").tag = "Session";
				casting = false;
			}
		}
	}
}