using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keys : MonoBehaviour {
	RaycastHit2D hit;
	public static bool keyred = false, keygreen = false, keyblue = false;

	void Start () {
		if(keyred == true) {delete ("key_red");}
		if(keyblue == true) {delete ("key_blue");}
		if(keygreen == true) {delete ("key_green");}
	}

	void Update () {
		
		if (Input.GetMouseButtonDown (0)) {
			hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);
		

			if (hit.collider != null && hit.transform.gameObject.tag == "key_red") {
				keyred = true;
				delete ("key_red");
			}

			if (hit.collider != null && hit.transform.gameObject.tag == "key_green") {
				keygreen = true;
				delete ("key_green");
			}	

			if (hit.collider != null && hit.transform.gameObject.tag == "key_blue") {
				keyblue = true;
				delete ("key_blue");
			}			
	}
	}

	void delete(string des){
		GameObject[] enemies = GameObject.FindGameObjectsWithTag(des);
		foreach(GameObject enemy in enemies)
		GameObject.Destroy(enemy);
	}	

}
