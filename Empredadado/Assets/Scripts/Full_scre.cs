using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Full_scre : MonoBehaviour {

	public Toggle tog;

	void Start () {
		if (Screen.fullScreen) tog.isOn = true;
		if (!Screen.fullScreen) tog.isOn = false;
	}


	void FixedUpdate () {
		if (tog.isOn == true)
			Screen.fullScreen = true;
		if (tog.isOn == false)
			Screen.fullScreen = false;
	}
}
