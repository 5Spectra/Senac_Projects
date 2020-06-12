using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Client : MonoBehaviour {

	public int nslo;
	public Animator aniNum;
	[SerializeField]bool already = false;
	[SerializeField]GameObject card;

	void start (){
		aniNum = GetComponent<Animator> ();
		card = card.GetComponent<GameObject>();
		card.SetActive(false);
	}

	void Update () {
		if (Time.timeScale == 0f) return;

		if (nslo == 1){
			transform.Translate (Vector3.up * 0.04f);
			aniNum.SetInteger ("anim", 1);
		}
		if (nslo == 2){
			transform.Translate (Vector3.down * 0.04f);
			aniNum.SetInteger ("anim", 2);
		}
		if (nslo == 3){
			transform.Translate (Vector3.right* 0.04f);
			aniNum.SetInteger ("anim", 3);
		}
		if (nslo == 4){
			transform.Translate (Vector3.left * 0.04f);
			aniNum.SetInteger ("anim", 4);
		}
	}

		void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.tag == "Player" && already == false){
			GetComponent<AudioSource>().Play();
			scoreNthings.score += 10;
			scoreNthings.ponts.text = "Pontos: " + scoreNthings.score;
			already = true;
			card.SetActive(true);
			}

		if (coll.gameObject.tag == "Rival" && already == false){
			already = true;
			card.SetActive(true);
		}
	}
}
