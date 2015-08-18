using UnityEngine;
using System.Collections;

public class pressButton : MonoBehaviour {

	public GameObject handler_prefab;
	public Vector3 pos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") ) {
			Instantiate(handler_prefab);
			Destroy(gameObject);
		}
	
	}
}
