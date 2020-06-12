using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

	public Transform alvo;

	void Update () {
		Vector3 posicaoRelativa = alvo.position - transform.position;
		Quaternion rotacao = Quaternion.LookRotation (posicaoRelativa);
		transform.rotation = rotacao;
		transform.position = new Vector3 (transform.position.x, transform.position.y, alvo.transform.position.z - 2f); 
	}
}
