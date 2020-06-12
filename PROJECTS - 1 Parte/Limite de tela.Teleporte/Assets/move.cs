using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float velocidade;

		
	void Update () {


		if (Input.GetAxisRaw("Horizontal") > 0)
		{
			transform.Translate(new Vector3 (0.2f , 0, Time.deltaTime));
		}

		if (Input.GetAxisRaw("Horizontal") < 0)
		{
			transform.Translate (new Vector3 (-0.2f, 0, Time.deltaTime));
		}
			
		if (Input.GetAxisRaw("Vertical") > 0)
		{
			transform.Translate (Vector3.up * 0.2f);
		}
		if (Input.GetAxisRaw("Vertical") < 0)
		{
			transform.Translate (Vector3.down * 0.2f);
		}

		}

	}
