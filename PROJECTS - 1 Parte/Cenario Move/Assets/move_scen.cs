using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_scen : MonoBehaviour {

	public float speed = 0;
	private Material mat;
	private float pos = 0;

	void Start () {
		mat = GetComponent<Renderer> ().material;
	}

	void Update () {
		float vel = Input.GetAxisRaw ("Horizontal");

		if (vel != 0){
				pos += speed * vel;
			mat.mainTextureOffset = new Vector2 (pos,0);
			}
	}
}
