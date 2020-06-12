using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Bike : MonoBehaviour {

	public int nslo;
	public Animator aniNum;

	public float veloc;

	void Update () {
		if (Time.timeScale == 0f) return;

		if (nslo == 1){
			transform.Translate (Vector3.up * veloc);
			aniNum.SetInteger ("anim", 1);
		}
		if (nslo == 2){
			transform.Translate (Vector3.down * veloc);
			aniNum.SetInteger ("anim", 2);
		}
		if (nslo == 3){
			transform.Translate (Vector3.right * veloc);
			aniNum.SetInteger ("anim", 3);
		}
		if (nslo == 4){
			transform.Translate (Vector3.left * veloc);
			aniNum.SetInteger ("anim", 4);
		}
	}

	void OnCollisionEnter2D(Collision2D coll){

		if (tag == "Bike") { GetComponent<AudioSource>().Play(); }

		if (tag == "Car") {GetComponent<AudioSource>().Play(); }

	}
}
