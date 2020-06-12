using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour {

	public Instanciador other;
	public GameObject gamer;

	void OnCollisionEnter2D (Collision2D coll){

		if (coll.gameObject.tag == "Player") {	
			Destroy (this.gameObject);
			Matador.velBola += 0.1f; //desafio
		}
	}
}
