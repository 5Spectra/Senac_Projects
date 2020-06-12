using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paredes_vai : MonoBehaviour {


	void Start () {
		
	}
	

	void Update () {
		//print (transform.position.x.ToString ());
		//faz com que quando o persongem chegue a certo posição X, ele seja teleportado para a outra posição

		if (transform.position.x < -9.6f) {//esquerda
			transform.position = new Vector3 (9.6f, transform.position.y, transform.position.z);		}
		
		if (transform.position.x > 9.6f) {//direita
			transform.position = new Vector3 (-9.6f, transform.position.y, transform.position.z);		}
			
		//faz com que quando o persongem chegue a certo posição Y, ele seja teleportado para a outra posição
		if (transform.position.y > 7f) {//cima
			transform.position = new Vector3 (transform.position.x, -7f, transform.position.z);		}

		if (transform.position.y < -7f) {//baixo
			transform.position = new Vector3 (transform.position.x, 7f, transform.position.z);		}
		
		Debug.Log(2);
	}
	void FixedUpdate(){

		Debug.Log(1);
	}







}
