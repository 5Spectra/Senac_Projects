using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman_move : MonoBehaviour {

	public float speed;
	Vector2 dest = Vector2.zero;

	void Start () {
		dest = transform.position;

		//print ("UP " + Vector2.up);print ("Down " + Vector2.down);print ("Left " + Vector2.left);print ("Right " + Vector2.right);
	}

	void FixedUpdate () {
		Vector2 p = Vector2.MoveTowards (transform.position, dest, speed);
		GetComponent<Rigidbody2D> ().MovePosition (p);

		float translation_X = Input.GetAxisRaw ("Horizontal") * Time.deltaTime;
		float translation_Y = Input.GetAxisRaw ("Vertical") * Time.deltaTime;

		//if ((Vector2)transform.position == dest) {

		if (translation_X < 0 && valid (-Vector2.right))
			dest = (Vector2)transform.position - Vector2.right;//10
		if (translation_X > 0 && valid (Vector2.right))
			dest = (Vector2)transform.position + Vector2.right;
		if (translation_Y < 0 && valid (-Vector2.up))
			dest = (Vector2)transform.position - Vector2.up;
		if (translation_Y > 0 && valid (Vector2.up))
			dest = (Vector2)transform.position + Vector2.up;
		//}

		Vector2 dir = dest - (Vector2)transform.position;
		//print ("Direcao " + dir);

		GetComponent<Animator> ().SetFloat ("DirX", dir.x);
		GetComponent<Animator> ().SetFloat ("DirY", dir.y);
	}

	bool valid (Vector2 dir){
		Vector2 pos = transform.position;
		RaycastHit2D hit = Physics2D.Linecast (pos + dir, pos);
		return(hit.collider == GetComponent<Collider2D> ());
	}
}
