using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluezeficar : MonoBehaviour {

	GameObject[] spawnBlue, spawnWhite;
	GameObject currentPoint;
	int index;
	SpriteRenderer spr;
	public Sprite azul;
	GameObject objt;

	void Start()
	{
		blue_do(azul);
	}

	public void blue_do(Sprite abc){
		spawnBlue = GameObject.FindGameObjectsWithTag("point");
		index = Random.Range (0, spawnBlue.Length);
		currentPoint = spawnBlue[index];
		spr = currentPoint.GetComponent<SpriteRenderer>();
		spr.sprite = abc;
		currentPoint.tag = "bblue";
	}
	public void Random_C(){
		spawnWhite = GameObject.FindGameObjectsWithTag("point");
		for (int i = 0; i < spawnWhite.Length; i++) {
			float rand = Random.Range (-7,7); 
			float radom = Random.Range (-4,4);
			spawnWhite [i].transform.position = new Vector2 (rand, radom);	}
	}

	}
