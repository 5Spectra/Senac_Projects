using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highscore : MonoBehaviour {


	void Start () {
		if (scoreNthings.score_total > PlayerPrefs.GetInt("HighScore", 0)){
			PlayerPrefs.SetInt("HighScore", scoreNthings.score_total);
		}
	}
}
