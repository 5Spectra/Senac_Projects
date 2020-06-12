using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_Move : MonoBehaviour {

	//public Transform destino;
	public float speed;

	public Transform[] waypoint;
	int point;

	void FixedUpdate () {

		if (transform.position != waypoint [point].position) {
			Vector2 p = Vector2.MoveTowards (transform.position, waypoint [point].position, speed);
			GetComponent<Rigidbody2D> ().MovePosition (p); 
		} 
		else 
			point = (point + 1) % waypoint.Length;

		Vector2 dir = waypoint[point].position - transform.position;

		GetComponent<Animator> ().SetFloat ("DirX", dir.x);
		GetComponent<Animator> ().SetFloat ("DirY", dir.y);

		if (Data_Base.isPower == true)
			GetComponent<SpriteRenderer>().color = Color.blue;
		else
			GetComponent<SpriteRenderer>().color = Color.white;
	}

	void OnTriggerEnter2D (Collider2D coll){
		if (coll.gameObject.CompareTag ("Player")) {
			if (Data_Base.isPower == true) {
				Data_Base.score += 400;
				Destroy (gameObject);
			}
			else if (Data_Base.isPower == false)
				Destroy (coll.gameObject);
		}
	}
}
