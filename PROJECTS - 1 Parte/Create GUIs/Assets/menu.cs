using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {

	public GUIStyle fonte;

	// Use this for initialization
	void Start () {
		fonte = new GUIStyle ();
		fonte.fontSize = 50;
		fonte.normal.textColor = Color.yellow;
		print (Screen.orientation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnGUI(){

		GUI.Box (new Rect (10,10,400,400),"Menu");

		GUI.BeginGroup (new Rect (10, 10, 400, 400));

		if (GUI.Button (new Rect (10, 30, 180, 30), "Ola André eu sou útil")) {
			print ("Oi André!!! eu fui útil");
		}
		if (GUI.Button (new Rect (10, 70, 180, 30), "Ola André eu sou útil")) {
			print ("Oi André!!! eu fui útil");
		}
		if (GUI.Button (new Rect (10, 110, 180, 30), "Ola André eu sou útil")) {
			print ("Oi André!!! eu fui útil");
		}

		GUI.Label (new Rect (10, 150, 180, 30), "Mensagem", fonte);

		GUI.EndGroup ();

	}

}
