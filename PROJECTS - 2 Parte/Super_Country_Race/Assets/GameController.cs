﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject[] players = new GameObject[2];
	public Text HudPrincipal, hudVoltas;
	public int voltaAtual = 0, maximoVoltas = 5;

	private float timer, delay = 1f;
	private int contador = 4;

	void Start () {

		timer = Time.time;

		foreach (GameObject m_gameObject in players) {
			m_gameObject.GetComponent<PlayerController> ().enabled = false;
		}

		hudVoltas.text = string.Format ("{0}/{1}", voltaAtual, maximoVoltas);


	}

	void Update () {

		if (contador >= 0) {
			if (delay < (Time.time - timer)) {
				timer = Time.time;
				contador--;
			}

			switch (contador) {
				case 4:
					HudPrincipal.text = "Super Country Race";
					break;
				case 3:
					HudPrincipal.text = "READY!";
					break;
				case 2:
					HudPrincipal.text = "SET!";
					break;
				case 1:
					HudPrincipal.text = "GO!";
					foreach (GameObject m_gameObject in players){
					m_gameObject.GetComponent<PlayerController>().enabled = true;
					}
					break;
				case 0:
					HudPrincipal.text = "";
					break;
				default:
					break;
			}
				
		}

	}

	public void UpdateVoltas(int voltaPlayer){
		if (voltaPlayer > voltaAtual) {
			voltaAtual = voltaPlayer;
			hudVoltas.text = string.Format ("{0}/{1}", voltaAtual, maximoVoltas);
		}
	}

	public void FinishRace(GameObject winner){
		foreach (GameObject m_gameObject in players) {
			if (m_gameObject == winner)
				m_gameObject.GetComponent<PlayerController> ().enabled = true;
			else
				m_gameObject.SetActive (false);
		}

		HudPrincipal.text = string.Format ("Player {0} ganhou!!", winner.GetComponent<PlayerController>().playerID);
	}

}