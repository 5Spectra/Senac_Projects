using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class full_check : MonoBehaviour {

	public Toggle full_s;

	void Start(){
		if (Screen.fullScreen)
			full_s.isOn = true;
		else 
			full_s.isOn = false;
	}

	public void full(){
		if (!full_s.isOn)
		Screen.fullScreen = false;
		if (full_s.isOn)
		Screen.fullScreen = true;

	}
}
