using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour {

	public GameObject intant, assasin;


	void Start () {
		
		Intancias (6, -7.5f);
		Intancias (6, -5f);
		Intancias (5, -2.5f);
		Intancias (5, 0f);
		Intancias (5, 2.5f);
		Intancias (6, 5f);
		Intancias (6, 7.5f);

	}
	

	void Intancias (int tospawn, float x)
	{
		float y = 4;
		for (int a = 1; a < tospawn; a++) {
			Instantiate (intant, new Vector3 (x, y, 1f), Quaternion.identity);
			y -= 2f;
		}
	}
}
		
