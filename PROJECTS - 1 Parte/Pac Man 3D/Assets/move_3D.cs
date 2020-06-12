using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_3D : MonoBehaviour {

	classe_ script = new classe_();
	Transform player;
	public GameObject ini, fim, chao, binoc, camerar;
	public float num = 0.2f;

	void Start(){
		player = GetComponent<Transform> ();
		script.set_velo (num);
	}

	void Update () {
		script.moves (player);
		script.rotete (player);
		script.binoc_ (binoc, camerar);
	}

	void OnCollisionEnter (Collision coll){
		if (coll.gameObject == fim)
		script.fim (gameObject, ini);
		//gameObject.transform.position = ini.transform.position;

		if (coll.gameObject == chao)
		script.fim (gameObject, ini);
	}
}
