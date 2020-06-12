using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour {

	public GameController gameController;
	Transform[] checkpoints;
	int maxCheckpoints = 0, checkpointAtual = 0, voltaAtual = 0, maximoVoltas;


	void Awake () {
		GameObject checkpointContainer = GameObject.FindGameObjectWithTag ("CheckpointsContainer");

		checkpoints = new Transform[checkpointContainer.transform.childCount];

		for (int i = 0; i < checkpointContainer.transform.childCount; i++) {
			checkpoints [i] = checkpointContainer.transform.GetChild (i);
		}
	}

	void Start(){
		maximoVoltas = gameController.maximoVoltas;
		maxCheckpoints = checkpoints.Length - 1;
	}	

	void OnTriggerEnter (Collider other) {
		if (other.CompareTag ("Checkpoint")){
			if (other.transform == checkpoints [checkpointAtual]){
				if (checkpointAtual < maxCheckpoints) {
					if (checkpointAtual == 0) {
						if (voltaAtual == maximoVoltas) {
							gameController.FinishRace (gameObject);
						} else {
							voltaAtual++;
							gameController.UpdateVoltas (voltaAtual);
						}
					}
					checkpointAtual++;
				} 
				else {
					checkpointAtual = 0;
				}
			}
		}
	}
}
