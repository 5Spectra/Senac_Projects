using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using System.IO;

public class Escreva : MonoBehaviour {

	public InputField field;

	public Text[] score_places;
	public TextAsset txt;

	int lineNumber;
	string[] lines_of_text;

	void Start () {
		
	}

	public void writing() {

		StreamWriter leitor = new StreamWriter ();
		leitor.WriteLine ();
		leitor.Close ();
	}

	public void reading(){

		if (txt){ lines_of_text = txt.text.Split("\n"[0]); }

		for (int x = 0; x < 10; x++) {
			score_places [x].text = lines_of_text [x];
		}
	}
}
