using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limite_derradeiro : MonoBehaviour {


	void Update () {
		var x = transform.position.x;
		var y = transform.position.y;

		if (x > 30 || x < -30 || y > 30 || y < -30)
			Destroy(this.gameObject);
	}
}
