using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_fase1 : MonoBehaviour {

	public GameObject[] intan;
	bool ready = true;
		
	void Update () {

		if (ready){

			rand_spr_right(3f,-9f,1.5f);
			rand_spr_left(3f,9f,0.5f);
			rand_spr_right(3f,-9f,-3.45f);
			rand_spr_left(3f,9f,-4.5f);
			/*
			StartCoroutine(Delay(intan[0],3f,-9f,1.5f));
			StartCoroutine(Delay(intan[1],3f,9f,0.5f));
			StartCoroutine(Delay(intan[0],3f,-9f,-3.45f));
			StartCoroutine(Delay(intan[1],3f,9f,-4.5f));
			*/
		}
	}

	IEnumerator Delay(GameObject spawn, float lag, float x, float y){

		ready = false;
		Instantiate(spawn, new Vector3(x,y), Quaternion.identity);
		yield return new WaitForSeconds (lag);
		ready = true;
	}

	void rand_spr_right( float lag, float x, float y){
		int num = Random.Range(0,2); //0 homen - 1 mulher
			
		if (num == 0)
			StartCoroutine(Delay(intan[0],lag,x,y));
		else
			StartCoroutine(Delay(intan[2],lag,x,y));
	}

	void rand_spr_left( float lag, float x, float y){
		int num = Random.Range(0,2); //0 homen - 1 mulher

		if (num == 0)
			StartCoroutine(Delay(intan[1],lag,x,y));
		else
			StartCoroutine(Delay(intan[3],lag,x,y));
	}
}
