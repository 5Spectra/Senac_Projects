using UnityEngine;
using System.Collections;

public class nome : MonoBehaviour {

	private Rigidbody2D player2D;
	public float speed = 0;
	private SpriteRenderer posicao;


	void Start () {

		// pegar as propriedades
		player2D = GetComponent <Rigidbody2D>();
		posicao = GetComponent <SpriteRenderer>();

	}

	void Update () {

		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			player2D.transform.Translate ( 0,(speed * 20) * (Time.deltaTime / 2), 0);
		}

		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			player2D.transform.Translate ( 0,(speed * -20) * (Time.deltaTime / 2), 0);

		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {

			posicao.flipX = true;
			player2D.transform.Translate ((speed * -20) * (Time.deltaTime / 2), 0, 0);
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {

			posicao.flipX = false;
			player2D.transform.Translate ((speed * 20) * (Time.deltaTime / 2), 0, 0);
		}
			
	}

}


