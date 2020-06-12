using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	float timer_s = 20;
	public Text timtx;

	public Image black;
	public Animator anim;

	void Start () {
	}

	void Update () {

		timer_s -= Time.deltaTime;
		timtx.text = "Tempo: " + Mathf.Round(timer_s) +" s";

		if (timer_s <= 0){ //|| Input.GetKeyDown(KeyCode.Return)){
			StartCoroutine(fade("Troca_fase"));
		}
	}	

	IEnumerator fade(string cena){
		anim.SetBool("Fade", true);
		yield return new WaitUntil(()=>black.color.a == 1);
		UnityEngine.SceneManagement.SceneManager.LoadScene (cena);
	}
}
