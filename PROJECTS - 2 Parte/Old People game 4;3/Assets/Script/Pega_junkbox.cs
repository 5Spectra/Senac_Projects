using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pega_junkbox : MonoBehaviour {

	GameObject jukebox;

	void Start () {
		jukebox = GameObject.Find ("JukeBox");
		jukebox.SetActive (false);
	}

	public void inicio(string cena){
		jukebox.SetActive (true);
		SceneManager.LoadScene(cena);
	}
}
