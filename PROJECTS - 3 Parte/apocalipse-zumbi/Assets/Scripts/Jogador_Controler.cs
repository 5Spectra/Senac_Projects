﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador_Controler : MonoBehaviour {

	public float velocidade = 10;
	Vector3 direcao;
	public LayerMask MascaraChao;

	public bool Vivo;
	public GameObject TextoGameOver;

	void Start(){
		TextoGameOver.SetActive (false);
		Time.timeScale = 1;
	}

	void Update () {
		float eixoX = Input.GetAxis ("Horizontal");
		float eixoZ = Input.GetAxis ("Vertical");

		direcao = new Vector3 (eixoX, 0,eixoZ);
		//transform.Translate (direcao * velocidade * Time.deltaTime);

		if(direcao != Vector3.zero){
			GetComponent<Animator> ().SetBool ("Movendo", true);
		}
		else{
			GetComponent<Animator> ().SetBool ("Movendo", false);
		}

		if (Vivo == false) {
			if (Input.GetButtonDown ("Fire1")) {
				SceneManager.LoadScene ("main");
			}
		}

	}

	void FixedUpdate(){
		
		Rigidbody movimente = GetComponent<Rigidbody>();
		movimente.MovePosition (movimente.position + (direcao * velocidade * Time.deltaTime));

		Ray raio = Camera.main.ScreenPointToRay (Input.mousePosition);
		Debug.DrawRay (raio.origin, raio.direction * 100, Color.red);

		RaycastHit impacto;

		if (Physics.Raycast (raio, out impacto, 100, MascaraChao)) {
			Vector3 posicaoMiraJogador = impacto.point - transform.position;
			posicaoMiraJogador.y = transform.position.y;
			Quaternion novaRotacao = Quaternion.LookRotation (posicaoMiraJogador);
			GetComponent<Rigidbody> ().MoveRotation (novaRotacao);		
		}

	}
}
