using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class high_check : MonoBehaviour {

	public Text high;

	void Start () {

		high.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
	}

	void FixedUpdate () {

		if (Input.GetKeyDown (KeyCode.J) && Input.GetKeyDown (KeyCode.K) && Input.GetKeyDown (KeyCode.L) ){
			PlayerPrefs.SetInt("HighScore", 0);
			high.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
		}
	}
}
