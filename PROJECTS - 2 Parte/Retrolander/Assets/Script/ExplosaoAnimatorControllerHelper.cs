using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosaoAnimatorControllerHelper : MonoBehaviour {

	public void TerminouAnimação(){
		GameController gc = GameObject.FindWithTag ("GameController").GetComponent<GameController>();
		gc.OnGameOver();
	}
}
