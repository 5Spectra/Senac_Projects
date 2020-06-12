using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float velocidade;
	public Animator varAnimacao;
	private SpriteRenderer jogador;

	void Start(){
		varAnimacao = GetComponent<Animator>();
		jogador = GetComponent<SpriteRenderer>();
	}

	void Update () {

		//positivo direita e cima // negativo esquerda e baixo
		if (Input.GetAxisRaw("Horizontal") > 0)
		{
			transform.Translate(new Vector3 (0.2f * velocidade, 0, Time.deltaTime));

			varAnimacao.SetInteger ("andar", 1);
			jogador.flipX = false;
		}

		if (Input.GetAxisRaw("Horizontal") < 0)
		{
			transform.Translate (new Vector3 (-0.2f * velocidade, 0, Time.deltaTime));
			varAnimacao.SetInteger ("andar", 1);
			jogador.flipX = true;
		}
			
		if (Input.GetAxisRaw("Vertical") > 0)
		{
			transform.Translate (Vector3.up * 0.2f * velocidade);
			varAnimacao.SetInteger ("andar", 0);
		}
		if (Input.GetAxisRaw("Vertical") < 0)
		{
			transform.Translate (Vector3.down * 0.2f * velocidade);
			varAnimacao.SetInteger ("andar", 0);
		}

		}

	}
