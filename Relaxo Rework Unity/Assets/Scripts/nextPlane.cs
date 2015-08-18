using UnityEngine;
using System.Collections.Generic;

public class nextPlane : MonoBehaviour {
	//public GameObject next_prefab;
	public GameObject canvas;
	public Vector3 textPosition = new Vector3(451.96f,316.18f,-900.58f);
	// Use this for initialization
	void Start () {
		canvas = GameObject.FindGameObjectWithTag ("Canvas");

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			//next_prefab = Instantiate(next_prefab,textPosition, Quaternion.identity) as GameObject;
			//next_prefab.transform.parent = canvas.transform;
			//next_prefab.transform.position = textPosition;
			Destroy(gameObject);
		}
	
	}

}
