using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : bluezeficar {

	public float velocidade;
	SpriteRenderer sr;
	GameObject aaa;
	public Sprite preto, blue, branco;
	public Text pontuacaoTXT, timed;
	public static int pontos = 0;
	public float timer;

	void Start () {
		TurnOn();
		Radom();
	}
		
	void Update () {
		timer -= Time.deltaTime;
		timed.text = "Tempo: " + Mathf.Round(timer);
		if(timer < 1)
		{
			TurnOff();
			UnityEngine.SceneManagement.SceneManager.LoadScene("Show");}

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
			if (na_to_br.normal == true){sr.sprite = preto;	}
			aaa.tag = "point";
			pontos += 1;
			pontuacaoTXT.text = "Pontos: " + pontos.ToString();
			if (na_to_br.chaos == true) {sr.sprite = branco; Random_C ();}
			blue_do(blue);
			Radom();
		}
	}
	void TurnOff(){ this.enabled = false;}
	void TurnOn(){ this.enabled = true;}
	}
