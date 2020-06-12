using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_B : MonoBehaviour {

	SpriteRenderer sr;
	GameObject aaa;
	public Sprite preto, blue;
	string compar;
	int inter;

	void Start () {inter = colisortest.randi; Bluzeficar2();}

	void OnCollisionEnter2D (Collision2D colisor){
		Debug.Log(compar);
		Debug.Log(gameObject.name);

		//if (SpriteRenderer == "blue"){
		if (colisor.gameObject.tag == "Player"){			
			Debug.Log("tarde");
			sr.sprite = preto;
			Bluzeficar();
			}}
	}
		
	void Bluzeficar(){
		inter = Random.Range(1,14);
		Bluzeficar2();
		}

	void Bluzeficar2(){
		compar = inter.ToString();
		aaa = GameObject.FindGameObjectWithTag (compar);
		sr = aaa.GetComponent<SpriteRenderer>();
		sr.sprite = blue;
	}
}
