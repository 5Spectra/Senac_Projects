using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Final_scrpt : MonoBehaviour {
	
	public Text empre_txt, c_total, pont_total, thanks;

	public Image black;
	public Animator anim;

	public AudioSource source;

	void Start () {
		//client_total = Mathf.FloorToInt (scoreNthings.score_total * 0.35f);
		c_total.text = "Clientes totais: " + scoreNthings.score_total * 0.1f;
		pont_total.text =  "Pontuação total: " + scoreNthings.score_total.ToString();
		conta(scoreNthings.score_total);
		thanks.text = "Obrigado por jogar " + scoreNthings.nome;
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
			StartCoroutine(fade());
	}

	IEnumerator fade(){
		anim.SetBool("Fade", true);
		yield return new WaitUntil(()=>black.color.a == 1);
		scoreNthings.dia = 0;
		scoreNthings.score = 0;
		scoreNthings.score_total = 0;
		scoreNthings.nome = "";
		scoreNthings.empresa = "";
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Hello");
	}

	void conta(int score){
		var texte = "A empresa " + scoreNthings.empresa + " foi um... ";
		string texto = "";

		if (score < 180)
			texto = texte + "Preciso mesmo te contar?, joga direito!!";

		if (score > 180)
			texto = texte + "Fracasso, a sua empresa não consiguirá durar nem um ano";

		if (score > 360)
			texto = texte + "Quase sucesso, você tentou, mas não conseguio seu comercio durará algum tempo";

		if (score > 540)
			texto = texte + "Sucesso, a sua empresa gerará renda o suficiente para se sustentar por longos anos";

		if (score > 640)
			texto = texte + "Estouro, se tornou super conhecida em sua região virando ponto de referência";
		
		StartCoroutine(TipeDialogue(texto));
	}

	IEnumerator TipeDialogue (string dialogue) {
		yield return new WaitForSeconds (2f);
		bool playSound = true;
		foreach (char letter in dialogue.ToCharArray()) {
			empre_txt.text += letter;

			if (playSound)
				source.Play();

			playSound = !playSound;

			yield return null;	
		}
	}
}
