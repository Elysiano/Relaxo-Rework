using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BackgroundSlideshow : MonoBehaviour {

	//Pictures
	public Texture[] myTextures = new Texture[5];
	int maxTextures;
	int arrayPos = 0;

	//Slideshow Timer
	public float slideShowTimer = 0.0f;
	public float slideShowDuration = 10.0f;

	//Colors and fade effect
	//0 = 0% opacity, 1 = 100% opacity
	Color originalColor;
	public float colorFadeTime = 1.0f;
	float colorFadeTimer = 0f;
	float colorFade = 0f;
	bool fadeInEffect = true; 

	//Picture movement
	public float movementSpeed = 1f;
	public Vector2 movementDirection = new Vector2 (1f,0f);

	void Start () 
	{
		maxTextures = myTextures.Length;
		originalColor = GetComponent<RawImage> ().color;
		GetComponent<RawImage> ().color = new Color (originalColor.r, originalColor.g, originalColor.b, 0f);
	}

	void Update () 
	{
		transform.Translate (movementDirection * movementSpeed * Time.deltaTime);

		//the timer of the slideshow
		slideShowTimer += Time.deltaTime;

		//Picture gets an amount of opacity based on the in and out effects
		GetComponent<RawImage> ().color = new Color (originalColor.r, originalColor.g, originalColor.b, colorFade);

		//fade in effect
		if(slideShowTimer >= 0.0f && slideShowTimer <= colorFadeTime)
		{
			colorFadeTimer += Time.deltaTime;

			if(colorFadeTimer >= 0.0f && colorFadeTimer < 1f)
			{
				colorFade += Time.deltaTime;
			}
			else
			{
				colorFadeTimer = 1f;
				colorFade = 1f;
			}
		}

		//fade out effect
		if(slideShowTimer >= slideShowDuration - colorFadeTime)
		{
			colorFadeTimer -= Time.deltaTime;

			if(colorFadeTimer >= 0.0f && colorFadeTimer < 1f)
			{
				colorFade -= Time.deltaTime;
			}
			else
			{
				colorFadeTimer = 0f;
				colorFade = 0f;
			}
		}

		//change images
		if (slideShowTimer >= slideShowDuration) 
		{
			if (arrayPos == maxTextures) 
			{
				//reset array index so the slideshow restarts with the first picture
				arrayPos = 0;
			}
			else
			{
				arrayPos++;
				GetComponent<RawImage>().texture = myTextures [arrayPos];

				//get a new movement direction
				float randomNumberMovement = Random.Range (-1f, 1f);

				if (randomNumberMovement < 0f)
				{
					//move left
					movementDirection = new Vector2 (-1f,0f);
				}
				else
				{
					//move right
					movementDirection = new Vector2 (1f,0f);
				}

				//get a new movement speed
				float randomNumberSpeed = Random.Range (0.1f, 1.5f);
				movementSpeed = randomNumberSpeed;
			}

			//reset slideShowTimer to zero
			slideShowTimer = 0.0f;
		}


		//move pictures at a random direction (maybe add random speed?) 
	}
}
