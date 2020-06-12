using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow : MonoBehaviour {

	public Transform camera_jogo;
	public Transform jogador;
	public float follow, limeteCamX, limeteCamY;

	void Update () {
		//cima direta 7.14 e 10.55
		//baixo esquerda 7.14 e -10.55

		/*
		//if ((Input.GetAxisRaw("Horizontal") > 0) || (Input.GetAxisRaw("Horizontal") < 0)){
		camera_jogo.position = Vector3.Lerp (camera_jogo.position, new Vector3 (jogador.position.x, camera_jogo.position.y, camera_jogo.position.z), follow); //}
		}
		//if ((Input.GetAxisRaw("Vertical") > 0) || (Input.GetAxisRaw("Vertical") < 0)){
		camera_jogo.position = Vector3.Lerp (camera_jogo.position, new Vector3 (camera_jogo.position.x, jogador.position.y, camera_jogo.position.z), follow); //}
		}*/


	limeteCamX = jogador.position.x;
	if (limeteCamX > 7.8f) { limeteCamX = 10.55f; }
	else if (limeteCamX < -7.8f) { limeteCamX = -10.55f; }

	limeteCamY = jogador.position.y;
	if (limeteCamY > 5.6f) { limeteCamY = 7.14f; }
	else if (limeteCamY < -5.6f) { limeteCamY = -7.14f; }

camera_jogo.position = Vector3.Lerp (
	camera_jogo.position, 

	new Vector3 ( limeteCamX,limeteCamY, camera_jogo.position.z), follow);

	/*camera_jogo.position = Vector3.Lerp (camera_jogo.position, new Vector3 (limeteCamX, camera_jogo.position.y, camera_jogo.position.z), follow);
	camera_jogo.position = Vector3.Lerp (camera_jogo.position, new Vector3 (camera_jogo.position.x, limeteCamY, camera_jogo.position.z), follow);*/


	//limita a posicao do jogador na direita
	if (jogador.position.x > 18.8f) {
	jogador.position = new Vector3 (18.8f, jogador.position.y, jogador.position.z);
	}
	//limita a posicao do jogador na esquerda
	if (jogador.position.x < -18.8f) {
	jogador.position = new Vector3 (-18.8f, jogador.position.y, jogador.position.z);
	}
	//limita a posicao do jogador no alto
	if (jogador.position.y > 10.32f) {
	jogador.position = new Vector3 (jogador.position.x, 10.32f, jogador.position.z);
	}
	//limita a posicao do jogador em baixo
	if (jogador.position.y < -10.32f) {
	jogador.position = new Vector3 (jogador.position.x, -10.32f, jogador.position.z);
}
}

}
