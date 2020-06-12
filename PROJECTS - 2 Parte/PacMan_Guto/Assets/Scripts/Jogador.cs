using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour {

	public Transform frente;
	public float speed;

	Animator anim;

	void Start()
	{
		anim = GetComponent<Animator>();
	}

	void Update()
	{
		float translation_h = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
		float translation_v = Input.GetAxisRaw("Vertical") * Time.deltaTime;

		GetComponent<Rigidbody2D> ().MovePosition (Vector2.MoveTowards (transform.position, frente.position, speed)); 

		if (translation_h > 0)
			frente.position = new Vector3 (transform.position.x + 2,transform.position.y);

		if (translation_h < 0)
			frente.position = new Vector3 (transform.position.x - 2,transform.position.y);

		if (translation_v > 0)
			frente.position = new Vector3 (transform.position.x,transform.position.y + 2);

		if (translation_v < 0)
			frente.position = new Vector3 (transform.position.x,transform.position.y - 2);


		Vector2 dir = frente.position - transform.position;

		GetComponent<Animator>().SetFloat ("DirX", dir.x);
		GetComponent<Animator>().SetFloat ("DirY", dir.y);
			
	}
}