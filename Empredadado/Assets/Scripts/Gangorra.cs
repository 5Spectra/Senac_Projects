using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gangorra : MonoBehaviour {

	bool volta;

	void Update () {
		var trz = transform.rotation.z;

		//print(trz);

		if (trz > 0.11) volta = true;
		if (trz < -0.11) volta = false;

		if (volta == false)
			transform.Rotate(Vector3.forward * 0.6f);

		if (volta == true)
		transform.Rotate(Vector3.back * 0.6f);
	}
}
