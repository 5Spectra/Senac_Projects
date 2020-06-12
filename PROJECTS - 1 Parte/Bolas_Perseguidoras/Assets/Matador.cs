using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matador : MonoBehaviour {

	public static float velBola;
	[SerializeField] float aaa;

	void Start () {
		velBola = 0.05f;
	}

	void Update () {
		transform.position = Vector3.Lerp (transform.position, new Vector3 (Movimento.posx, Movimento.posy), Time.deltaTime * velBola);
	}
}

