using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTexture : MonoBehaviour
{

	private PlayerController playerControllerScript;
	public float Scrollx = 0.5f;
	public float Scrolly = 0.5f;

	//public PlayerController Player;

	//public RandomObstacle CurrentSpeed;

	// Use this for initialization
	void Start()
	{
		playerControllerScript = GameObject.Find("Player1").GetComponent<PlayerController>();
	}

	// Update is called once per frame
	void Update()
	{



		float OffsetX = Time.time * Scrollx;
		float OffsetY = Time.time * Scrolly;
		if (playerControllerScript.gameOver == false)
		{
			GetComponent<Renderer>().material.mainTextureOffset = new Vector2(OffsetX, OffsetY);
		}
		else if (playerControllerScript.gameOver == true)
		{
			Scrollx = 0f;
			Scrolly = 0f;

		}


	}
}

