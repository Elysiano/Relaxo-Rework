using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	public bool toggleDisplayed = false;

	public void Update()
	{
		if (toggleDisplayed) 
		{
			//turn arrow
		}
	}

	public void DisableBoolInAnimator(Animator anim)
	{
		anim.SetBool ("isDisplayed", false);
		toggleDisplayed = false;
	}

	public void EnableBoolInAnimator (Animator anim)
	{
		anim.SetBool ("isDisplayed", true);
		toggleDisplayed = true;
	}

	public void NavigateTo(int scene)
	{
		Application.LoadLevel (scene);
	}

	public void ToggleBoolInAnimator(Animator anim)
	{
		if (toggleDisplayed == false) {
			anim.SetBool ("isDisplayed", true);
			toggleDisplayed = true;
		} 
		else 
		{
			anim.SetBool ("isDisplayed", false);
			toggleDisplayed = false;
		}
	}

}
