using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour {

	public Animator anima;

	void Start () {

	}

	void FixedUpdate () {
		transform.Translate (new Vector3 (-0.2f, 0f, 0));

		if (transform.position.x < -8) {
			transform.position = new Vector3 (8,0);
		}
		if (Input.GetKey (KeyCode.P)) {
			anima.SetInteger ("anim", 3);
		}

		if (Input.GetKey (KeyCode.A)) {
			Time.timeScale = 0.1f;	
		}
		if (Input.GetKey (KeyCode.D)) {
			Time.timeScale = 1;	
		}
	}
}
