using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float velocidade = 0;
	public AudioSource som;
		
	void Update () {
		//cima 3.7 baixo -3.7 direita 7,6 esquerda -7.6

		if (transform.position.x < -5.6) {
			transform.position = new Vector3 (-5.6f, transform.position.y, transform.position.z);

			if (!som.isPlaying) som.Play (); //if(!) é uma negação a frase é "se o som não estiver rodando[fazer o som]"
		}

		if (transform.position.x > 5.6)
		transform.position = new Vector3 (5.6f, transform.position.y, transform.position.z);
		
		if (transform.position.y < -3f)
			transform.position = new Vector3 (transform.position.x, -3f, transform.position.z);
		
		if (transform.position.y > 3.7)
			transform.position = new Vector3 (transform.position.x, 3.7f, transform.position.z);
		

		if (Input.GetAxisRaw("Horizontal") > 0)
		{
			transform.Translate(new Vector3 (velocidade, 0, Time.deltaTime));
		}

		if (Input.GetAxisRaw("Horizontal") < 0)
		{
			transform.Translate (new Vector3 (-velocidade, 0, Time.deltaTime));
		}
			
		if (Input.GetAxisRaw("Vertical") > 0)
		{
			transform.Translate (Vector3.up * velocidade);
		}
		if (Input.GetAxisRaw("Vertical") < 0)
		{
			transform.Translate (Vector3.down * velocidade);
		}
			
		
	}

	}
