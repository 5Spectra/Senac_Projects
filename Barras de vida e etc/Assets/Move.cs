using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour {
	[SerializeField]
	private Animator animacao;
	[SerializeField][Range(0.1f, 1f)]
	private float vel = 0.1f;
	[SerializeField]
	bool ground;
	GameObject aaa;

	public Image cor;

	void Start () {
		animacao = this.GetComponent<Animator>();
		ground = false;
		aaa = GameObject.Find("Clone");
	}
	

	void Update () {

		if (cor.fillAmount == 0) Destroy(aaa);

			var vert = Input.GetAxis("Vertical");
			var hori = Input.GetAxis("Horizontal");

		if (vert > 0 && ground == true){
			transform.Translate (Vector3.up * 5f);
			ground = false;
		}

		if (hori > 0){
			transform.Translate (Vector3.right * vel);
			animacao.SetInteger("Direcao", 1);
			transform.eulerAngles = new Vector2(0, 0);
			}
		else if (hori < 0){
			transform.Translate (Vector3.right * vel);
			animacao.SetInteger("Direcao", 1);
			transform.eulerAngles = new Vector2(0, 180);
			}
		else{
			animacao.SetInteger("Direcao", 0);
			}
	}

	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject)
			ground = true;
		
		if (coll.gameObject.tag == "Finish")
			cor.fillAmount -= 0.1f;

	}
}
