using UnityEngine;
using System.Collections;

public class shutDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (GameObject.Find("MainHandler(Clone)") != null)
		{
			GetComponent<AudioSource>().volume = 0;
		}
	}
}
