using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float velocidade;

	void Start () {
		Radom();

	}
		
	void Update () {


		if (Input.GetAxisRaw("Horizontal") > 0)
		{
			transform.Translate(Vector2.right * velocidade * Time.deltaTime);
			//transform.eulerAngles = new Vector2 (0, 0);
		}

		if (Input.GetAxisRaw("Horizontal") < 0)
		{
			transform.Translate(Vector2.left * velocidade * Time.deltaTime);
			//transform.eulerAngles = new Vector2(0, 180);
		}
			
		if (Input.GetAxisRaw("Vertical") > 0)
		{
			transform.Translate(Vector2.up * velocidade * Time.deltaTime);
			//transform.eulerAngles = new Vector2(0, 0);
		}
		if (Input.GetAxisRaw("Vertical") < 0)
		{
			transform.Translate(Vector2.down * velocidade * Time.deltaTime);
			//transform.eulerAngles = new Vector2(0 , -180);
		}

		}

	 void Radom (){
		float rand = Random.Range (-7,7); 
		float radom = Random.Range (-4,4);
		transform.position = new Vector2(rand , radom);
	}

	}
