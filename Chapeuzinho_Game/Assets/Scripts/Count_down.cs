﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Count_down : MonoBehaviour {

	float number = 10;
	public Text temporizador, doces_c;

	void Start(){
		//doces
		doces_c.text = Player_Collisions.Doce_Count.ToString() + " de " + 40;
		Player_Collisions.Doce_Count = 0;
	}

	void Update () {
		//temporizador
		if (number > 0)
			number -= Time.deltaTime;
		else
			SceneManager.LoadScene ("Menu");

		string texto = (Mathf.Round(number)).ToString ();
		temporizador.text = texto;
	}

	public void Troca_cena(string cena){
		SceneManager.LoadScene (cena);
	}
}
