using UnityEngine;
using System.Collections;

public class sceneTimer : MonoBehaviour {
	public float timer = 3.0f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) 
		{
			ChangeToScene("MainMenu");
				}
	}
				public void ChangeToScene (string SceneToChangeTo)
				{
				Application.LoadLevel (SceneToChangeTo);
			}
}
