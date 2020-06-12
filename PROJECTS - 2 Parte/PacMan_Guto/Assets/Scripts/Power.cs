using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour {

	void Start(){
		Data_Base.isPower = false;
	}

	void OnTriggerEnter2D (Collider2D coll){
		if (coll.gameObject.CompareTag ("Player"))
			GetComponent<Collider2D> ().enabled = false;
			GetComponent<SpriteRenderer> ().sprite = null;
			StartCoroutine (powerOn());
	}

	IEnumerator powerOn(){
		Data_Base.isPower = true;
		yield return new WaitForSeconds (6);
		Data_Base.isPower = false;
		Destroy (gameObject);
	}
}