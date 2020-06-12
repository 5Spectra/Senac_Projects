using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_rect : MonoBehaviour {


	void Update () {
		float x = transform.position.x;
		var y = transform.position.y;

		transform.Translate (new Vector3 (0.05f, 0f));

		if (x > 10)
			transform.position = new Vector3 (-10f, y);
	}
}
