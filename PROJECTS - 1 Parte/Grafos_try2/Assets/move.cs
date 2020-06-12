using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : colisortest {

	public float velocidade;
	SpriteRenderer sr;
	GameObject aaa;
	public Sprite preto, blue;
	public Text pontuacaoTXT;
	private int pontos = 0;

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

	void OnCollisionEnter2D (Collision2D colisor){

		if (colisor.gameObject.tag == "bblue"){
			aaa = GameObject.FindGameObjectWithTag ("bblue");
			sr = aaa.GetComponent<SpriteRenderer>();
			sr.sprite = preto;
			aaa.tag = "point";
			Radom();
			blue_do(blue);

			pontos += 1;
			pontuacaoTXT.text = pontos.ToString();
		}}
	

	}
