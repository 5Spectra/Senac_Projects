using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class na_to_br : MonoBehaviour {

	RaycastHit2D hit;
	public static bool chaos, normal;

	void Start () {
	}

	void Update () {

		if (Input.GetMouseButtonDown(0)){
			hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

			if (hit.collider !=null && hit.transform.gameObject.tag == "Normal"){ SceneManager.LoadScene("Grafos_2"); chaos = false; normal = true;}

			if (hit.collider !=null && hit.transform.gameObject.tag == "Chaos"){SceneManager.LoadScene("Chaos");chaos = true; normal = false;}
				
			if (hit.collider !=null && hit.transform.gameObject.tag == "Sair"){ Application.Quit(); }

		}
	

}
}