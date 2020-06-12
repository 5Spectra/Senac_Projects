using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisortest : MonoBehaviour {

	GameObject[] spawnPoints;
	GameObject currentPoint;
	int index;
	SpriteRenderer spr;
	public Sprite azul;

	void Start()
	{
		blue_do(azul);
	}

	public void blue_do(Sprite abc){
		spawnPoints = GameObject.FindGameObjectsWithTag("point");
		index = Random.Range (0, spawnPoints.Length);
		currentPoint = spawnPoints[index];
		spr = currentPoint.GetComponent<SpriteRenderer>();
		spr.sprite = abc;
		currentPoint.tag = "bblue";
		print (currentPoint.name);
	}

	}
