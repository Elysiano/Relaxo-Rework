using UnityEngine;
using System.Collections.Generic;
using System;
using System.Linq;


public class cubesDraaien : MonoBehaviour {

	//tappen op telefoon voor starten
	public GameObject playPlane;
	public bool newPhase = true;
	public float yWaarde;
	public float speed = 10.0f;


	public float calTimer = 44.0f;
	public bool gameRunning = true;
	public float calibrating = 0.0f;
	public bool starting = false;

	public float vergrotingsFactor = 10.0f;
	
	public List<float> arrayAvgY = new List<float>();

	public float startWaardeY;
	public bool startCheck = true;
	//public AudioClip music1;
	public float currentY;

	public float avgY;
		
		void Start()
		{
			starting = true;	
			repeating ();
		}

		void Update() 
		{
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
			yWaarde = Input.acceleration.y;
			gameRunning = true;
			transform.rotation = Input.gyro.attitude;
			
			arrayAvgY.Add (currentY);
			avgY = arrayAvgY.Average();

			
					
			if (gameRunning)
			{
				calTimer -= Time.deltaTime;
				
				if(starting == false)
				{
					starting = false;
				}
			}

			if (calTimer <= 0)
			{
				CancelInvoke();
				calTimer = 0;

				if(newPhase)
				{
					Instantiate(playPlane);
					newPhase = false;
				}

			}
				//currentX = Input.acceleration.x;
				currentY = yWaarde * vergrotingsFactor;

				//RenderSettings.ambientLight
//				if (calTimer > 0)
//				{
//					calibration ();
//				}
		}
	
//		void calibration()
//		{
//			//float tmpX = currentX;

//
//		}

		void repeating()
		{
			if (starting)
			{
			//InvokeRepeating("calibration", 0.01f, 4.0f);
			starting = false;
			}
		}

		void OnGUI()
		{
			GUIStyle avgFont = new GUIStyle ();
			avgFont.fontSize = 50;
			avgFont.normal.textColor = Color.cyan;
			
			if (calTimer > 0)
			{
			//GUI.Label(new Rect(Screen.width / 2 - 350 ,Screen.height / 2+50 ,150 ,150), "Timer "+calTimer.ToString(), avgFont);
			//GUI.Label(new Rect(Screen.width / 2 - 350 ,Screen.height / 2-50 ,150 ,150), "avgY "+avgY.ToString(), avgFont);
			}

		}



}