using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intacia_test : MonoBehaviour {

	public GameObject up, down, right, left;

	void Start () {
		Intancias (left, 8, 4f, 4);
		Intancias (right, -8, 0f, 3);
		Intancias (left, 8, -4f, 4);

	}

	void Intancias (GameObject obj ,float x, float y, int lado)
	{
		Instantiate (obj, new Vector3 (x, y, 1f), Quaternion.identity);
		}
	}
