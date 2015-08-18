using UnityEngine;
using System.Collections;

public class changeScene : MonoBehaviour {

	public void ChangeToScene (string sceneToChangeTo)
	{
		Application.LoadLevel (sceneToChangeTo);
	}

	/*public void SluitApp ()
	{
		Application.Quit();
	}*/
}