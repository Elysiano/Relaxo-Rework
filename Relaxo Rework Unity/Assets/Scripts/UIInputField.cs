using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIInputField : MonoBehaviour
{
	public Text charText;
	public Text placeholderText;
	public changeScene script;
	bool Error = false;
	public float errorTimer;
	public static float outcome;
	public string aantal;

	// Use this for initialization
	void Start ()
	{
		charText = GameObject.Find ("CharText").GetComponent<Text> ();
		placeholderText = GameObject.Find ("Placeholder").GetComponent<Text> ();
		script = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<changeScene> ();
	}

	public void Update ()
	{
		if (errorTimer < 0)
		{
			Error = false;
		}

		errorTimer -= Time.deltaTime;
	}

	public void CharacterField(string inputFieldString)
	{
		charText.text = inputFieldString;
	}

	public void SubmitFunction ()
	{
		if (charText.text.Length <= 3 && charText.text != "0" && charText.text != "00" && charText.text != "000")
		{
			PlayerPrefs.SetString("Aantal", charText.text);
			aantal = PlayerPrefs.GetString("Aantal");
			outcome = float.Parse(aantal);
			script.ChangeToScene("HeadphoneScreen");
		}

		else if (placeholderText.enabled == true)
		{
			Error = true;
			errorTimer = 2.0f;
		}
	}

 	void OnGUI()
	{
		
		GUIStyle avgFont = new GUIStyle ();
		avgFont.fontSize = 14;
		avgFont.normal.textColor = Color.red;

		if (Error) 
		{
			GUI.Label(new Rect(Screen.width / 2 -135 ,Screen.height / 2, 150,150), "Voer een aantal in", avgFont);
		}
	}
}