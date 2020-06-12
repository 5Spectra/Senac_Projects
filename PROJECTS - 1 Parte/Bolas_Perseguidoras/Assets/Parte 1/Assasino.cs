using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assasino : MonoBehaviour {

	public static float velBola = 0.05f;
	[SerializeField] float aaa;

	void Start () {
		aaa = velBola;
		//velBola = 0.05f;
		print (aaa);
	}

	void Update () {
		transform.position = Vector3.Lerp (transform.position, new Vector3 (Move.posx, Move.posy), Time.deltaTime * velBola);
	}
}
