using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anima : MonoBehaviour {

	public AudioSource aaa;

	void Start () {
		aaa = GetComponent<AudioSource> ();
	}

	void Update () {
		transform.Translate (new Vector3 (0.1f,0f));
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "Player") {
			aaa.Play ();
		}
	}
}
