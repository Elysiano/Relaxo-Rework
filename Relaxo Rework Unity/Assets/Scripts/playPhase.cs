using UnityEngine;
using System.Collections.Generic;
using System;
using System.Linq;

public class playPhase : MonoBehaviour {

	public cubesDraaien script;

	public List<float> maxY = new List<float>();
	public List<float> minY = new List<float>();
	public List<float> breathInput = new List<float>();
	public List<float> breathOutput = new List<float>();
	public List<float> fullBreathList = new List<float>();

	public float playTimer;
	public float breathInTimer = 0.0f;
	public float breathOutTimer = 0.0f;
	public float fullBreath = 0.0f;

	float touchTimer = 2;
	float brightness;


	void Start ()
	{
		GameObject mainHandler = GameObject.FindGameObjectWithTag("MainCamera");
		script = mainHandler.GetComponent<cubesDraaien>();
		brightness = 1.0f;
		playTimer = UIInputField.outcome * 60;
	}

	void Update () 
	{

		if (Input.GetMouseButton(0)) {

			touchTimer-=Time.deltaTime;
			print (touchTimer);
				}
		if (Input.GetMouseButtonUp(0))
		{
			touchTimer = 2.0f;
		}
		playTimer -= Time.deltaTime;
		if (playTimer < 0 || touchTimer < 0) 
		{

			ChangeToScene();

				}
			float tmpY = script.currentY;
			
			if (script.currentY < script.avgY)
			{
				//Uitgeademd
				minY.Add(tmpY); //
				breathOutTimer += Time.deltaTime;
				breathInput.Add(breathInTimer);
				breathInTimer = 0.0f;

			}
			else
			{
				//Ingeademd
				maxY.Add(tmpY);
				breathInTimer += Time.deltaTime;
				breathOutput.Add(breathOutTimer);
				breathOutTimer = 0.0f;
				
			}

		if(breathOutput.Last() > 0.5f)
		{
			fullBreathList.Add (breathOutput.Last());
			breathOutput.Clear (); //Maakt de array leeg
		}

		if(breathInput.Last() > 0.5f)
		{
			fullBreathList.Add (breathInput.Last());
			breathInput.Clear ();
		}

	}
	public void ChangeToScene ()
	{
		Application.LoadLevel ("EndScreen");
	}
	void OnGUI() {
		GUIStyle avgFont = new GUIStyle ();
		avgFont.fontSize = 50;
		avgFont.normal.textColor = Color.cyan;
	//GUI.Label(new Rect(Screen.width / 2 -350 ,Screen.height / 2-50 ,150 ,150), "fullBreath "+ fullBreathList.Last().ToString(), avgFont);
	}
}
