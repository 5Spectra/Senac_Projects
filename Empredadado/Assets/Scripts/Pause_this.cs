using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_this : MonoBehaviour {

	bool pause; // pause = false \ !pause = true
	AudioSource stich;

    public GameObject player;
	public AudioSource songe;
	public Texture texct;

	public GUIStyle btn_home;

	void Start(){
		stich = GetComponent<AudioSource>();
	}

	void Update () {

		if (Input.GetKeyDown(KeyCode.P) && pause == false || Input.GetKeyDown(KeyCode.Escape) && pause == false){
			Time.timeScale = 0f;
			stich.Play();
			player.SetActive(false);
			songe.enabled = false;
			pause = true;
		}

		else if (Input.GetKeyDown(KeyCode.P)  && pause == true || Input.GetKeyDown(KeyCode.Escape) && pause == true){
			Time.timeScale = 1f;
			stich.Play();
			player.SetActive(true);
			songe.enabled = true;
			pause = false;
		}
	}

	void OnGUI(){
		if (pause == true){
			GUI.Box (new Rect(0,0,Screen.width,Screen.height),"");
			GUI.DrawTexture (new Rect (Screen.width * 0.25f, Screen.height * 0.4f, Screen.width * 0.5f, Screen.height * 0.25f),texct);
		//	if (GUI.Button (new Rect (0,0,Screen.width * 0.12f, Screen.height * 0.2f),"",btn_home)){
		//		reset();
		//		UnityEngine.SceneManagement.SceneManager.LoadScene("Hello");
		//	}
		//	GUI.TextArea(new Rect (0,Screen.height * 0.2f,Screen.width * 0.2f,1),"Cuidado o perderá todo seu progresso");
	}
}

	void reset(){
		Time.timeScale = 1f;
		scoreNthings.dia = 0;
		scoreNthings.score = 0;
		scoreNthings.score_total = 0;
		scoreNthings.nome = "";
		scoreNthings.empresa = "";
	}
}
