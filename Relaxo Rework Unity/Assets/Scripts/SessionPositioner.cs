using UnityEngine;
using System.Collections;

public class SessionPositioner : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "PositionerUp")
		{
			this.transform.position = new Vector3 (0,-550,0);
			print ("Ik raak");
		}

		if (coll.gameObject.tag == "PositionerDown")
		{
			this.transform.position = new Vector3 (0,550,0);
			print ("Ik raak");
		}
	}
}