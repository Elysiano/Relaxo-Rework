﻿using UnityEngine;
using System.Collections;

public class TouchGesture
{
	[System.Serializable]
	public class GestureSettings
	{
		public float minSwipeDist = 100;
		public float maxSwipeTime = 10;
	}
	private GestureSettings settings;
	private float swipeStartTime;
	private bool couldBeSwipe;
	public Vector2 startPos;
	private int stationaryForFrames;
	private TouchPhase lastPhase;
	public TouchGesture(GestureSettings gestureSettings)
	{
		this.settings = gestureSettings;
	}
	public IEnumerator CheckHorizontalSwipes(System.Action onDownSwipe, System.Action onUpSwipe, System.Action onRightSwipe, System.Action onLeftSwipe) //Coroutine, which gets Started in "Start()" and runs over the whole game to check for swipes
	{
		while (true)
		{ //Loop. Otherwise we wouldnt check continuously ;-)
			foreach (Touch touch in Input.touches)
			{ //For every touch in the Input.touches - array...
				switch (touch.phase)
				{
				case TouchPhase.Began: //The finger first touched the screen --> It could be(come) a swipe
					couldBeSwipe = true;
					startPos = touch.position;  //Position where the touch started
					swipeStartTime = Time.time; //The time it started
					stationaryForFrames = 0;
					break;
				case TouchPhase.Stationary: //Is the touch stationary? --> No swipe then!
					if (isContinouslyStationary(frames:6))
						couldBeSwipe = false;
					break;
				case TouchPhase.Ended:
					if (isASwipe(touch))
					{
						couldBeSwipe = false; //<-- Otherwise this part would be called over and over again.
						if (Mathf.Sign(touch.position.y - startPos.y) == 1f) //Swipe-direction, either 1 or -1.   
							onUpSwipe(); //Right-swipe
						
						else
							onDownSwipe(); //Left-swipe

//						if (Mathf.Sign(touch.position.x - startPos.x) == 1f) //Swipe-direction, either 1 or -1.   
//							onRightSwipe(); //Right-swipe
//						
//						else
//							onLeftSwipe(); //Left-swipe
					}

					if (isASwipe2(touch))
					{
						couldBeSwipe = false; //<-- Otherwise this part would be called over and over again.
//						if (Mathf.Sign(touch.position.y - startPos.y) == 1f) //Swipe-direction, either 1 or -1.   
//							onUpSwipe(); //Right-swipe
//						
//						else
//							onDownSwipe(); //Left-swipe
						
						if (Mathf.Sign(touch.position.x - startPos.x) == 1f) //Swipe-direction, either 1 or -1.   
							onRightSwipe(); //Right-swipe
						
						else
							onLeftSwipe(); //Left-swipe
					}

					break;
				}
				lastPhase = touch.phase;
			}
			yield return null;
		}
	}
	private bool isContinouslyStationary(int frames)
	{
		if (lastPhase == TouchPhase.Stationary)
			stationaryForFrames++;
		else // reset back to 1
			stationaryForFrames = 1;
		return stationaryForFrames > frames;
	}
	private bool isASwipe(Touch touch)
	{
		float swipeTime = Time.time - swipeStartTime; //Time the touch stayed at the screen till now.
		float swipeDist = Mathf.Abs(touch.position.y - startPos.y); //Swipe distance
		//float swipeDist2 = Mathf.Abs(touch.position.x - startPos.x); //Swipe distance
		return couldBeSwipe && swipeTime < settings.maxSwipeTime && swipeDist > settings.minSwipeDist;
		//return couldBeSwipe && swipeTime < settings.maxSwipeTime && swipeDist2 > settings.minSwipeDist;
	}

	private bool isASwipe2(Touch touch)
	{
		float swipeTime = Time.time - swipeStartTime; //Time the touch stayed at the screen till now.
		//float swipeDist = Mathf.Abs(touch.position.y - startPos.y); //Swipe distance
		float swipeDist2 = Mathf.Abs(touch.position.x - startPos.x); //Swipe distance
		//return couldBeSwipe && swipeTime < settings.maxSwipeTime && swipeDist > settings.minSwipeDist;
		return couldBeSwipe && swipeTime < settings.maxSwipeTime && swipeDist2 > settings.minSwipeDist;
	}
}