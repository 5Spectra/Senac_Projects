using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System;

public class Writer : MonoBehaviour {

	public InputField write_place;

	public Text high_score;

	public TextAsset text_file;
	string[] dialog_line;
	int lineNumber;

	//https://www.youtube.com/watch?v=8CRfL-2xnYU

	void Start(){
		if (text_file){
			dialog_line = text_file.text.Split("\n"[0]);
		}
	}

	void FixedUpdate(){
		if (lineNumber < 1)	lineNumber = 0;

		high_score.text = dialog_line [lineNumber];
	}

	public void Next (){
		lineNumber += 1;
	}
	public void Back (){
		lineNumber -= 1;
	}

	void try_catch(){
		try {
			
		}
		catch(Exception){
			
		}
	}
}
