using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour {
	public string volta;
	RaycastHit2D hit;

	void Start () {
		
	}
	

	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);

			if (Input.GetKeyDown (KeyCode.B)) {
				SceneManager.LoadScene (volta);
			}
			
			if (hit.collider != null && hit.transform.gameObject.tag == "back") {
				Debug.Log ("AE");
				SceneManager.LoadScene (volta);
			}

		
		}
	}
}


