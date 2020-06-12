using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click_Porta : MonoBehaviour {
	RaycastHit2D hit;
	public string canal = "";
	public string canal2 = "";

	void Start () {
	 
	}

	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);


			if (hit.collider != null && hit.transform.gameObject.tag == "trap") {
				Debug.Log ("Doi");
				SceneManager.LoadSceneAsync ("lose");
				}

			if (canal != ""){
				if (hit.collider != null && hit.transform.gameObject.tag == "porta_start") {
					Debug.Log ("ERROOOOOOOOOO");
					go_win ();
				}}		
			
			if (canal != ""){
			if (hit.collider != null && hit.transform.gameObject.tag == "porta") {
				Debug.Log ("AE");
					SceneManager.LoadScene (canal);
			}}
			
			if (canal2 != "") {
			if (hit.collider != null && hit.transform.gameObject.tag == "porta2") {
				Debug.Log ("IA");
				SceneManager.LoadScene (canal2);
				}}
					
		}
			 
	}
	IEnumerator timer(){
		print (Time.time);
		yield return new WaitForSeconds (5);
		print (Time.time);
	}

	public void go_win(){
		if (keys.keyred == true && keys.keygreen == true && keys.keyblue == true) {
			SceneManager.LoadScene ("win");
		
		} else {
			SceneManager.LoadScene ("verde_1");
		}
	}
}