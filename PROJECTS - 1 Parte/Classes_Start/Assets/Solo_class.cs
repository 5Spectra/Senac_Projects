using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Solo_class {

	private int coin;
	private string nome;
	private float velocidade;

		public int get_coin(){
			return coin;
		}

		public void set_coin (int c){
			coin = c;
		}
		//----------------------------------------
		public string get_nome(){
			return nome;
		}

		public void set_nome(string n){
			nome = n;
		}
		//----------------------------------------
		public float get_velocidade(){
			return velocidade;
		}

		public void set_velocidade(float v){
			velocidade = v;
		}
		//----------------------------------------
		public void move(Transform trans){
			
			if (Input.GetKey (KeyCode.W)){
			trans.transform.Translate (Vector3.forward * velocidade);
			}

			if (Input.GetKey (KeyCode.S)){
			trans.transform.Translate (Vector3.back * velocidade);
			}
		}

		public void pular(Rigidbody trans){

		if (Input.GetKey (KeyCode.Space)){
			trans.AddForce (Vector3.up * 70f);
			}
		}

}
