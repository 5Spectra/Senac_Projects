using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public Text hudRecorde;

	void Start(){
		if (PlayerPrefs.HasKey ("RECORDE"))
			hudRecorde.text = string.Format("RECORDE: {0}",PlayerPrefs.GetInt ("RECORDE"));
		else
			hudRecorde.text = "RECORDE: NADA";

	}

	public void quit (){
		Application.Quit ();
	}	

	public void Game_Start(){
		SceneManager.LoadScene ("principal");
	}

	public void Limpa_Recorde()
	{
		if (PlayerPrefs.HasKey ("RECORDE")) {
			PlayerPrefs.DeleteKey ("RECORDE");
			hudRecorde.text = "RECORDE: NADA";
		}
	}
}
