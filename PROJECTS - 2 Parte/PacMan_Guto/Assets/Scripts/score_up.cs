using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_up : MonoBehaviour {

	public Text pontuacao;
	public GameObject vitoria;

	void FixedUpdate () {
		
		pontuacao.text = Data_Base.score.ToString ();

		if (Data_Base.dots == Data_Base.dots_pre) {
			vitoria.SetActive (true);
		}
	}

	public void Sair(){
		Application.Quit ();
	}

	public void Novamente(){
		Data_Base.dots = 0;
		Data_Base.dots_pre = 0;
		Data_Base.score = 0;
		UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
	}

}
