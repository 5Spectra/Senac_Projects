using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multi_Cams : MonoBehaviour {

	public Camera[] cams;
	[SerializeField]
	int next;

	void Start () {

		for (int i = 1; i < cams.Length; i++) 
			cams[i].enabled = false;
		
	}
	
	void FixedUpdate () {
		int atualcam = next;

		if (Input.GetKeyDown(KeyCode.Q)){
			next += 1;	
				if (next == cams.Length)
					next = 0;
		}

		cams[next].enabled = true;

		if (atualcam != next)
			for (int i = 1; i < cams.Length; i++) 
				cams[i].enabled = false;
		

	}
}
