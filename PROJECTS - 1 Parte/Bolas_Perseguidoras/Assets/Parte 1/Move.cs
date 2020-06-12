using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour {

	public static float posx, posy, posz;
	[SerializeField][Range (0.1f, 1f)]
	private float vel;

	public static int pontos;
	public Text placar;

	void Start () {
		vel = 0.2f;
		pontos = 0;
	}
	
	void Update () {

		if (Input.GetAxisRaw("Horizontal") > 0)
		{
			transform.Translate (Vector3.right * vel);
		}

		if (Input.GetAxisRaw("Horizontal") < 0)
		{
			transform.Translate (Vector3.left * vel);
		}

		if (Input.GetAxisRaw("Vertical") > 0)
		{
			transform.Translate (Vector3.up * vel);
		}
		if (Input.GetAxisRaw("Vertical") < 0)
		{
			transform.Translate (Vector3.down * vel);
		}

		posx = transform.position.x;
		posy = transform.position.y;
		posz = transform.position.z;
}

	void OnCollisionEnter2D (Collision2D coll){

		if (coll.gameObject.tag == "Bola") {
			Destroy (this.gameObject);
		}

		if (coll.gameObject.tag == "Moeda") {
			pontos += 1;
			placar.text = pontos.ToString ();
		}
	}
}
