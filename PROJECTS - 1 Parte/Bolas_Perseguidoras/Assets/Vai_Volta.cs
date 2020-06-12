using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vai_Volta : MonoBehaviour {

	[SerializeField] [Range(-2f, 2f)]
	public float vaiX;
	float voltaX, voltaY,vaiY = -0.1f;
	bool pode = false, can = false, fazer = false;

	void Start () {
		
		//transform.position = new Vector3 (startX, 4f);
		voltaX = vaiX * -1;
		voltaY = vaiY * -1;
	}

	void Update () {
		
		var x = transform.position.x;
		var y = transform.position.y;

		if (pode == false && gameObject.name == "Bola_esquerda") {
			transform.Translate (new Vector3 (vaiX, vaiY));
			if (x >= 8)
				pode = true;
		}

		if (pode == true && gameObject.name == "Bola_esquerda"){
			transform.Translate (new Vector3 (voltaX, voltaY));
			if (x <= -8)
				pode = false;
		}
		//----------------------------------------------------------------
		if (can == false && gameObject.name == "Bola_direita") {
			transform.Translate (new Vector3 (vaiX, vaiY));
			if (x <= -8)
				can = true;
		}

		if (can == true && gameObject.name == "Bola_direita"){
			transform.Translate (new Vector3 (voltaX, voltaY));
			if (x >= 8)
				can = false;
		}
		//----------------------------------------------------------------

		if (fazer == false && gameObject.name == "Bola_meio") {
			transform.Translate (new Vector3 (0f, vaiY * 1.2f));
			if (y <= -4)
				fazer = true;
		}

		if (fazer == true && gameObject.name == "Bola_meio"){
			transform.Translate (new Vector3 (0f, voltaY * 1.2f));
			if (y >= 4)
				fazer = false;
		}
	}

}
