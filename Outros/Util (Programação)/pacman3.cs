using UnityEngine;
using System.Collections;

public class pacman : MonoBehaviour {

	private Rigidbody2D player2D;
	private int speed = 0;
	private SpriteRenderer posicao;

	void Start () {

		player2D = GetComponent <Rigidbody2D>();
		posicao = GetComponent <SpriteRenderer>();

	}

	void Update () {




		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			posicao.flipX = false;
			speed = 5;
			player2D.velocity = new Vector2 (speed, player2D.velocity.y);
		}
		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			posicao.flipX = false;
			speed = 0;
			player2D.velocity = new Vector2 (speed, player2D.velocity.y);
		}
		//-------------------------------------------------------------------
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			posicao.flipX = true;
			speed = -5;
			player2D.velocity = new Vector2 (speed, player2D.velocity.y);
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			posicao.flipX = true;
			speed = 0;
			player2D.velocity = new Vector2 (speed, player2D.velocity.y);
		}
		//-------------------------------------------------------------------
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			posicao.flipX = false;
			speed = 5;
			player2D.velocity = new Vector2 (player2D.velocity.y, speed);
		}
		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			posicao.flipX = false;
			speed = 0;
			player2D.velocity = new Vector2(player2D.velocity.y, speed);
		}
		//-------------------------------------------------------------------
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			posicao.flipX = false;
			speed = -5;
			player2D.velocity = new Vector2(player2D.velocity.x, speed);
		}
		if (Input.GetKeyUp (KeyCode.DownArrow)) {
			posicao.flipX = false;
			speed = 0;
			player2D.velocity = new Vector2(player2D.velocity.x, speed);;
		}
	}
}