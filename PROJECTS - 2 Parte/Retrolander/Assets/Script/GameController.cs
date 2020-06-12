using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public GameObject gameHUB;
	public GameObject MenuPause;
	public GameObject MenuGameOver;
	public GameObject MenuGameWin;

	private bool isPaused;

	private void Awake (){
		Time.timeScale = 1;
	}

	// Use this for initialization
	void Start () {
		isPaused = false;

		MenuPause.SetActive (false);
		MenuGameOver.SetActive (false);
		MenuGameWin.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Return)) {
			pauseManager ();
		}
		
	}
	private void pauseManager(){
		isPaused = !isPaused;
		if (isPaused)
			OnPaused ();
		else
			OnResume ();
	}
	private void OnPaused(){
		MenuPause.SetActive (true);
		gameHUB.SetActive (false);
		Time.timeScale = 0;
	}
	private void OnResume(){
		MenuPause.SetActive (false);
		gameHUB.SetActive (true);
		Time.timeScale = 1;
	}
	public void OnGameOver(){
		MenuGameOver.SetActive (true);
		gameHUB.SetActive (false);
		Time.timeScale = 0;
	}
	public void OnGameWin(){
		MenuGameWin.SetActive (true);
		gameHUB.SetActive (false);
	}
	public void Resume(){
		OnResume ();
	}
	public void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
	public void sair (){
		SceneManager.LoadScene ("Intro");
	}	
}
