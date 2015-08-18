using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class blinkLight : MonoBehaviour {
	
	Text flashingText;
	
	void Start(){
		//get the Text component
		flashingText = GetComponent<Text>();
		//Call coroutine BlinkText on Start
		StartCoroutine(BlinkText());
	}
	
	//function to blink the text
	public IEnumerator BlinkText(){
		//blink it forever. You can set a terminating condition depending upon your requirement
		while(true){
			//set the Text's text to blank
			flashingText.text= "Raak het scherm aan om door te gaan.";
			//display blank text for 0.5 seconds
			yield return new WaitForSeconds(1.0f);
			//display “I AM FLASHING TEXT” for the next 0.5 seconds
			flashingText.text= " ";
			yield return new WaitForSeconds(1.0f);
		}
	}
}