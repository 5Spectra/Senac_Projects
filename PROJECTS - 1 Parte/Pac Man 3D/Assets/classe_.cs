using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classe_ {

	float velocidade = 0.2f;

	public void set_velo (float velo){
		velocidade = velo;
	}

	public void fim(GameObject that, GameObject ini){
		that.transform.position = ini.transform.position;
	}

	public void wall_R (GameObject that){
		that.transform.Rotate (Vector3.down * 1);
	}

	public void jump (Transform trans){
		if (Input.GetKeyDown (KeyCode.Space))
		trans.transform.Translate (Vector3.up * 4);
	}
		
	public void rotete(Transform trans){
		if (Input.GetAxis ("Rotacao") < 0) {
			trans.transform.Rotate (Vector3.down * 2);
		}

		if (Input.GetAxis ("Rotacao") > 0) {
			trans.transform.Rotate (Vector3.up * 2);
		}
	}

	public void moves(Transform trans){

		// < negativo | > positivo
		if (Input.GetAxis ("Horizontal") < 0) {
			trans.transform.Translate (Vector3.left * velocidade);
		}

		if (Input.GetAxis ("Horizontal") > 0){
			trans.transform.Translate (Vector3.right * velocidade);
		}

		if (Input.GetAxis ("Vertical") < 0) {
			trans.transform.Translate (Vector3.back * velocidade);
		}

		if (Input.GetAxis ("Vertical") > 0) {
			trans.transform.Translate (Vector3.forward * velocidade);
		}
	}

	public void binoc_(GameObject bino, GameObject camerar){

		if (Input.GetKeyDown (KeyCode.B)) {
			if (bino.activeSelf) {
				camerar.transform.Translate (new Vector3 (0, 0, -20));
				bino.SetActive (false);
			} else {
				bino.SetActive (true);
				camerar.transform.Translate (new Vector3 (0, 0, 20));
			}
		}}

}
