using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuar : MonoBehaviour {

	public Text show_score;

	void Start(){
		show_score.text = move.pontos.ToString();
		move.pontos = 0;
	}

	void Update () {
		if (Input.anyKey){	System.Threading.Thread.Sleep(2000); UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");}
	}
}
