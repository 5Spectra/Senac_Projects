using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	Solo_class script;

	public TextMesh txtmesh;
	public string nomes;

	void Start () {
		script = new Solo_class ();
		script.set_nome (nomes);
		script.set_velocidade (0.5f);
		txtmesh.text = script.get_nome ();
	}
	
	void Update () {

		script.move (GetComponent<Transform> ());
		script.pular (GetComponent<Rigidbody> ());

	}


}
