using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BackgroundSlideshow : MonoBehaviour {

	public Sprite picture_0;
	public Sprite picture_1;
	public Sprite picture_2;
	public Sprite picture_3;
	public Sprite picture_4;
	public Sprite picture_5;
	public Sprite picture_6;
	public Sprite picture_7;
	public Sprite picture_8;
	public Sprite picture_9;
	public Sprite[] images;

	public Sprite OtherSprite;


	public float slideShowTimer = 0.0f;
	//random movementpoint for photos
	

	void Start () 
	{
		//images = gameObject.GetComponentsInChildren<Sprite> ();

//		foreach (Sprite image in images)
//		{
//			image.sprite = OtherSprite;
//		}

		images = new Sprite[]
		{
			picture_0,
			picture_1,
			picture_2,
			picture_3,
			picture_4,
			picture_5,
			picture_6,
			picture_7,
			picture_8,
			picture_9
		};

		gameObject.GetComponent<Image> ().sprite = images [Random.Range (0, images.Length)];


		//GetComponent<Image>() = images [Random.Range (0, images.Length)];
	}

	void Update () 
	{
		slideShowTimer += Time.deltaTime;

		if (slideShowTimer >= 5.0f) 
		{
			//GetComponent<Image>() = images [Random.Range (0, images.Length)];
			//images [Random.Range (0, images.Length)];

			//fade effect, see brackeys tutorial
			slideShowTimer = 0.0f;
		}
	}
}
