using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimento : MonoBehaviour {

	public static float posx, posy;
public static int pontos;

[SerializeField][Range (0.1f, 1f)] private float vel;

public Text placar;

float vida = 3;


void Start () {
	vel = 0.2f;
	pontos = 0;
}

void Update () {
		
		posx = transform.position.x;
		posy = transform.position.y;

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

}

void OnCollisionEnter2D (Collision2D coll){
		var x = transform.localScale.x;
		var y = transform.localScale.y;


	if (coll.gameObject.tag == "Bola") {
		vida -= 1;
		confirm_d ();
		transform.localScale = (new Vector3 (x - 0.2f, y - 0.2f, 1f));
	}

	if (coll.gameObject.tag == "Moeda") {
		pontos += 1;
		placar.text = pontos.ToString ();
	}
}

void confirm_d(){
	if (vida <= 0) {
		Destroy (this.gameObject);
	}
}
}
