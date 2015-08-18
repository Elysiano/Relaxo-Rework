using UnityEngine;
using System.Collections;

public class GyroscopeMovement : MonoBehaviour {

	//public float xWaarde = 0.0f;
	public float yWaarde = 0.0f;
	//public float zWaarde = 0.0f;

	public Vector3 forceVec;
	public Vector3 rotationRate;

	void Update () 
	{
		transform.rotation = Input.gyro.attitude;
		//float yWaarde = Input.gyro.rotationRate.y;
		//yWaarde *= 100.0f;


		GetComponent<Rigidbody>().AddForce(Input.gyro.userAcceleration.x * forceVec);
	}


}
