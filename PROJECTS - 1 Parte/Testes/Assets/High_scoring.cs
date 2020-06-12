using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class High_scoring : MonoBehaviour {

	public Text scoring;
	public Text best_s;

	void Start(){
		best_s.text = PlayerPrefs.GetInt ("HighScore", 0).ToString();
	}

	public void Rolling () {
		int num = Random.Range (1, 20);
		scoring.text = num.ToString ();

		if (num > PlayerPrefs.GetInt ("HighScore", 0)) {
			PlayerPrefs.SetInt ("HighScore", num);
			best_s.text = num.ToString ();
		}

	}

	public void Reset(){
		PlayerPrefs.DeleteKey("HighScore");
		//PlayerPrefs.DeleteAll ();
		best_s.text = "0";
	}
}
