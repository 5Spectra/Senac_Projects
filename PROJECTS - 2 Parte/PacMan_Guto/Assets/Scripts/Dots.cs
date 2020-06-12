using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dots : MonoBehaviour {

	void Start(){		
		Data_Base.dots_pre += 1;
	}

	void OnTriggerEnter2D (Collider2D coll){
		
		if (coll.gameObject.CompareTag("Player")) {
			Data_Base.score += 200;
			Data_Base.dots += 1;
			Destroy (gameObject);
		}	
	}
}
