using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevador : MonoBehaviour {

	public Transform posA, posB;
	public bool volta, close;
	public Transform entrada0, entrada1;
	public Transform saida0, saida1;

	void FixedUpdate() {
				
		if (Input.GetKeyDown (KeyCode.E)) {
			volta = !volta;		

			entrada0.rotation = Quaternion.AngleAxis(-110f, Vector3.right);
			entrada1.rotation = Quaternion.AngleAxis(110f, Vector3.forward);

			saida0.rotation = Quaternion.AngleAxis(0f, Vector3.up);
			saida1.rotation = Quaternion.AngleAxis(0f, Vector3.up);
		}

		if (volta == true) {
			transform.position = Vector3.MoveTowards (transform.position, posB.position, 2 * Time.fixedDeltaTime);
		} 
		else if (volta == false) {
			transform.position = Vector3.MoveTowards (transform.position, posA.position, 2 * Time.fixedDeltaTime);
		}

		if (transform.position == posA.position) {
			entrada0.rotation = Quaternion.AngleAxis(-110f, Vector3.right);
			entrada1.rotation = Quaternion.AngleAxis(0f, Vector3.forward);
		}

		if (transform.position == posB.position){
			entrada0.rotation = Quaternion.AngleAxis(0f, Vector3.right);
			entrada1.rotation = Quaternion.AngleAxis(110f, Vector3.forward);

			saida0.rotation = Quaternion.AngleAxis(-90f, Vector3.up);
			saida1.rotation = Quaternion.AngleAxis(90f, Vector3.up);
		}

	}
}
