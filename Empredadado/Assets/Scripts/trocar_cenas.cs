using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class trocar_cenas : MonoBehaviour {

	public Image black;
	public Animator anim;

	//public void Change_cena (string nome_cena) {
	//	SceneManager.LoadScene (nome_cena);}

	public void Change_to_intro (int idx) {
		scoreNthings.intru = idx;
		StartCoroutine(fade_intro(-1));}

	public void back_to () {
		if (scoreNthings.intru == 1)
			StartCoroutine(fade("Escolha"));

		else if (scoreNthings.intru == -1)
			StartCoroutine(fade("Menu"));
	}
		
	public void troca_fade(string lvlName){
		StartCoroutine(fade(lvlName));
	}

	IEnumerator fade_intro(int idx){
		anim.SetBool("Fade", true);
		yield return new WaitUntil(()=>black.color.a == 1);
		SceneManager.LoadScene ("Instrucoes");
	}

	IEnumerator fade(string cena){
		anim.SetBool("Fade", true);
		yield return new WaitUntil(()=>black.color.a == 1);
		SceneManager.LoadScene (cena);
	}
}
