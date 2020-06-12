using UnityEngine;
using System.Collections;

public class perso : MonoBehaviour {

	private Rigidbody2D player2D;
	private int gravidade = 0;
	public float speed = 0;
	private SpriteRenderer posicao;


	void Start () {

		// pegar as propriedades
		player2D = GetComponent <Rigidbody2D>();
		posicao = GetComponent <SpriteRenderer>();

	}

	void Update () {

		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			gravidade = -1;
			player2D.gravityScale = gravidade;
			}

		if (Input.GetKeyUp(KeyCode.UpArrow)) {
			gravidade = 1;
			player2D.gravityScale = gravidade;
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {

		posicao.flipX = true;
		player2D.transform.Translate ((speed * -2)
		* (Time.deltaTime / 2), 0, 0);
		}

		if (Input.GetKeyDown (KeyCode.)) {

			posicao.flipX = true;
			player2D.transform.Translate ((speed * -2)
				* (Time.deltaTime / 2), 0, 0);
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {

			posicao.flipX = false;
			player2D.transform.Translate ((speed * 2)
			* (Time.deltaTime / 2), 0, 0);
				}
			
	}

}
