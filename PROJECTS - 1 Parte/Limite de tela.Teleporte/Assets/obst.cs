using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obst : MonoBehaviour {

	public GameObject objeto;

	void Start () {
		transform.position = new Vector3 (transform.position.x, -5.67f, transform.position.z);
	}

	void Update () {
		float n = Random.Range (0.5f, 1f);

		transform.Translate (Vector3.up * (n / 10));

		if (transform.position.y > 5.65f) {
			Instantiate(objeto);
			Destroy(this.gameObject);
		}

	}
}
