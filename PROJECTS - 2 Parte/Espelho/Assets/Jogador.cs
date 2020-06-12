using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour {

	public GameObject abc;

	void Update () {

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical") * 0.5f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

		if (Input.GetKeyDown (KeyCode.Space))
			abc.SendMessage ("destroir");

    }
}
