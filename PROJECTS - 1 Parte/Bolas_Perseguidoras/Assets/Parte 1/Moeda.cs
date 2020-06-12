using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour {

	public Instanciador other;
	public GameObject gamer;

	void OnCollisionEnter2D (Collision2D coll){
	
		if (coll.gameObject.tag == "Player") {	
			Assasino.velBola += 0.1f;
			//other.Intancias_S ();
			Intancias_S ();
			Destroy (this.gameObject);

			Matador.velBola += 0.1f; //desafio
		}
	}

	void Intancias_S () {
		int rand = Random.Range (1, 4);
		float x = 0, y = 0;

		if (rand == 1) {
			x = 10;
			y = 6;
		}
		if (rand == 2) {
			x = 10;
			y = -6;
		}
		if (rand == 3) {
			x = -10;
			y = 6;
		}
		if (rand == 4) {
			x = -10;
			y = -6;
		}
		Instantiate (gamer, new Vector3 (x, y, 1f), Quaternion.identity);
	}
}
