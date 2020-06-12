using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour {

	public Animator anima;

	void Start () {
		anima = GetComponent <Animator> ();
	}

	void Update () {
		
		if (Input.anyKey) anima.SetBool ("stop", false);

		if (!Input.anyKey) {
			anima.SetInteger ("anim", 5);
			anima.SetBool ("stop", true);
		}

		if (Input.GetAxisRaw ("Horizontal") > 0) { //direita
			anima.SetInteger ("anim", 3);
			transform.Translate (Vector3.right * 0.1f);
		}

		if (Input.GetAxisRaw ("Horizontal") < 0) { //esquerda
				anima.SetInteger ("anim", 4);
			transform.Translate (Vector3.left * 0.1f);
		}

		if (Input.GetAxisRaw ("Vertical") > 0) { //cima
			anima.SetInteger ("anim", 1);
			transform.Translate (Vector3.up * 0.1f);
		}
		if (Input.GetAxisRaw ("Vertical") < 0) { //baixo
			anima.SetInteger ("anim", 2);
			transform.Translate (Vector3.down * 0.1f);
		}
			
	}


	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.tag == "Bike") { setador_enemy(20); }

		if (coll.gameObject.tag == "Car") { setador_enemy(40);	}

	}

	void setador_enemy(int menos){
		scoreNthings.score -= menos; 
		if(scoreNthings.score < 0) { scoreNthings.score = 0;}
		scoreNthings.ponts.text = "Pontos: " + scoreNthings.score;
	}
}
