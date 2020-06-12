using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paredes : MonoBehaviour {


	void FixedUpdate () {
		if (transform.position.x > 10 && this.gameObject.tag == "Car")
			transform.position = new Vector3(-10f, -2.1f);
				
		if (transform.position.x < -10 && this.gameObject.tag == "Bike")
			transform.position = new Vector3(10f, -0.5f);
	}
}
