using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listai : MonoBehaviour {

	private static int contador;
	//private static string[] kkj = new string[3];
	private int x,xx,xxx;


	void Start () {
		x = 1; xx = 1; xxx = 1;contador = 1;
	}

	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.A)) {
			if (contador == 1 && x == 1) {
				contador = +1;
				//kkj [0] = "meia";
				x = 2;
				transform.position = new Vector3 (4, 2f, 0);
			}
			
			if (contador == 2 && x == 1) {
				contador = +1;
				//kkj [1] = "meia";
				x = 2;
				transform.position = new Vector3 (4, -1f, 0);
			}
			
			if (contador == 3 && x == 1) {
				contador = +1;
				//kkj[2] = "meia";
				x = 2;
				transform.position = new Vector3 (4, -3.7f, 0);
			}
			if (x == 2) {
				transform.position = new Vector3 (-4, 2f, 0);
				x = 0;
				contador = 0;
			}
		}
			
		//----------------------------------------------------------------------------
		if (Input.GetKeyDown (KeyCode.S)) {
			if (contador == 1 && x == 1) {
				contador = +1;
				xx = 2;
				transform.position = new Vector3 (4, 2f, 0);
			}

			if (contador == 2 && x == 1) {
				contador = +1;
				xx = 2;
				transform.position = new Vector3 (4, -1f, 0);
			}

			if (contador == 3 && x == 1) {
				contador = +1;
				xx = 2;
				transform.position = new Vector3 (4, -3.7f, 0);
			}
			if (xx == 2) {
				transform.position = new Vector3 (-4, -1f, 0);
				xx = 0;
				contador = 0;
			}
			//----------------------------------------------------------------------------
			if (Input.GetKeyDown (KeyCode.D)) {
				if (contador == 1 && x == 1) {
					contador = +1;
					xxx = 2;
					transform.position = new Vector3 (4, 2f, 0);
				}

				if (contador == 2 && x == 1) {
					contador = +1;
					xxx = 2;
					transform.position = new Vector3 (4, -1f, 0);
				}

				if (contador == 3 && x == 1) {
					contador = +1;
					xxx = 2;
					transform.position = new Vector3 (4, -3.7f, 0);
				}
				if (xxx == 2) { //*
					transform.position = new Vector3 (-4, -3.7f, 0);
					xxx = 0;
					contador = 0;
				}
			}
		}
	}
}
