using UnityEngine;
using System.Collections;

public class LolWat : MonoBehaviour {
//	Vector3 movement = new Vector3 ();
	//float speed = 5.0f;
	float timer = 4.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {

			transform.Translate (Vector3.up * Time.deltaTime);
				}

		if (timer <= 4 && timer > 0) {
			transform.Translate (Vector3.down * Time.deltaTime);

				}
		if (timer <= -4) 
		{
			timer = 4.0f;
				}
//		Debug.Log(timer);
	
	}
}
