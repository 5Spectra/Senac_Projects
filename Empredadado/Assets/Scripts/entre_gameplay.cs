using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class entre_gameplay : MonoBehaviour {
	
	public Text pont_t, pont_a, day;
	public Image black;
	public Animator anim;

	string next_fase;

	void Start () {
		scoreNthings.score_total += scoreNthings.score;
		scoreNthings.dia += 1;
		pont_t.text = scoreNthings.score_total.ToString();
		pont_a.text = scoreNthings.score.ToString();
		day.text = "Dia " + scoreNthings.dia.ToString();
		scoreNthings.score = 0;
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.Return))
		{
			if (scoreNthings.dia < 3){ //6 pois o fase 5 irá carregar a fase 6 e a fase 6 carrega a fase 7
			dias();
			StartCoroutine(fade(next_fase));
			}
			else
			StartCoroutine(fade("final"));
		}
	}

	void dias(){
		//if (scoreNthings.dia == 1) next_fase = "fase1";
		for (int x = 1; x < 4; x++)
			if (scoreNthings.dia == x) next_fase = "fase1" ;//"fase" + x;
			
	}

	IEnumerator fade(string cena){
		anim.SetBool("Fade", true);
		yield return new WaitUntil(()=>black.color.a == 1);
		UnityEngine.SceneManagement.SceneManager.LoadScene (cena);
	}
}
