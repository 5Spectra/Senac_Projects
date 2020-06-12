using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour {

	CharacterController objCharControler;
	Transform transformCam;

	Vector3 moveCamFrente;
	Vector3 moveMove;
	Vector3 normalZeroPiso = Vector3.zero;
	Vector3 vetorDirecao = Vector3.zero;

	float giro = 3, frente = 3, velocidade = 5, pulo = 5;

	void Start () {
		objCharControler = GetComponent<CharacterController> ();
		transformCam = Camera.main.transform;
		objCharControler.material.bounciness = 0;
	}
	

	void Update () {
		moveCamFrente = Vector3.Scale (transformCam.forward, new Vector3 (1, 0, 1)).normalized;
		moveMove = Input.GetAxis ("Vertical") * moveCamFrente + Input.GetAxis ("Horizontal") * transformCam.right;

		vetorDirecao.y -= 5f * Time.deltaTime;
		objCharControler.Move (vetorDirecao * Time.deltaTime);
		objCharControler.Move (moveMove * velocidade * Time.deltaTime);

		if (moveMove.magnitude > 1f)
			moveMove.Normalize ();

		moveMove = transform.InverseTransformDirection (moveMove);
		moveMove = Vector3.ProjectOnPlane (moveMove, normalZeroPiso);
		giro = Mathf.Atan2(moveMove.x, moveMove.z);
		frente = moveMove.z;

		objCharControler.SimpleMove (Physics.gravity);
		aplicaRotacao ();

		if (Input.GetButton ("Jump"))
		if (objCharControler.isGrounded == true)
			vetorDirecao.y = pulo;
	}

	void aplicaRotacao(){
		float turnSpeed = Mathf.Lerp (180, 360, frente);
		transform.Rotate (0, giro * turnSpeed * Time.deltaTime, 0);
	}
}
