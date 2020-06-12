using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {

	public int playerID;

	public GameObject corpo;
	public Transform mira;
	public Rigidbody bomba;

	public AudioSource audioMovimento, audioTiro;
	public AudioClip veiculoParado, veiculoAndando;

	public float velocidade = 12f, velocidadeGiro = 180f, forcaTiro = 20f;
	public float inputValorMovimento, inputValorGiro;

	string nomeEixoMovimento, nomeEixoGiro, botaoTiro;
	Rigidbody rb;

	void Awake () {
		rb = GetComponent<Rigidbody> ();

		Color color = Color.white;
		switch (playerID) {
		case 1:
			color = Color.red;
			break;
		case 2:
			color = Color.blue;
			break;
		}

		corpo.GetComponent<MeshRenderer> ().material.color = color;
	}

	void Start () {

		nomeEixoMovimento = "Vertical" + playerID;
		nomeEixoGiro = "Horizontal" + playerID;
		botaoTiro = "Fire" + playerID;

		rb.isKinematic = false;
		inputValorMovimento = 0f;
		inputValorGiro = 0f;
	}

	void Update(){
		inputValorMovimento = Input.GetAxis (nomeEixoMovimento);
		inputValorGiro = Input.GetAxis (nomeEixoGiro);

		Move ();
		Turn ();

		if (Input.GetButtonDown (botaoTiro))
			Fire ();

		AudioMotor();
	}

	void Move(){
		Vector3 movimento = transform.forward * inputValorMovimento * velocidade * Time.deltaTime;
		rb.MovePosition (rb.position + movimento);
	}

	void Turn(){
		float giro = inputValorGiro * velocidadeGiro * Time.deltaTime;
		Quaternion turnRotation = Quaternion.Euler (0f,giro, 0f);
		rb.MoveRotation (rb.rotation * turnRotation);
	}

	void Fire(){
		Rigidbody bombaIntance = Instantiate (bomba, mira.position, mira.rotation) as Rigidbody;
		bombaIntance.velocity = forcaTiro * mira.forward;
		audioTiro.Play ();
	}

	void AudioMotor(){
		if (Mathf.Abs (inputValorMovimento) < 0.1f && Mathf.Abs (inputValorGiro) < 0.1f) {
			if (audioMovimento.clip == veiculoAndando) {
				audioMovimento.clip = veiculoParado;
				audioMovimento.Play ();
			}
		}

		else if (audioMovimento.clip == veiculoParado){
			audioMovimento.clip = veiculoAndando;
			audioMovimento.Play ();
		}

	}
}
