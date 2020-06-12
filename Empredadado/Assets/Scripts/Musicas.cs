using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Musicas : MonoBehaviour {

	Scene cena;

	void Start () {
		DontDestroyOnLoad(gameObject);
	}

	void FixedUpdate(){
		cena = SceneManager.GetActiveScene();
		if (cena.name == "inicio"){
			Destroy (gameObject);
		}
	}
}
