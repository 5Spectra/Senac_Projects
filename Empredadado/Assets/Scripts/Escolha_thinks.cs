using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Escolha_thinks : MonoBehaviour {

	public InputField nick, industry;
	public GameObject eror;

	public AudioClip erro_m, vai_m; 
	public AudioSource source_m;

	void Start(){
		para(scoreNthings.empresa,scoreNthings.nome);
	}

	public void bota_things(){
		scoreNthings.nome = nick.text;
		scoreNthings.empresa = industry.text;
	}

	public void error(int idx){
	
		if(nick.text != "" && industry.text != "")
		{			
			source_m.clip = vai_m;
			source_m.Play();
			StartCoroutine(music_end(idx));
		}
		if (nick.text == "" || industry.text == ""){
			source_m.clip = erro_m;
			source_m.Play();
			eror.SetActive(true);
		}
	}

	public void eror_miss(){
		eror.SetActive(false);
	}

	void para(string a, string b){
		industry.text = a ;
		nick.text= b ;
	}

	IEnumerator music_end(int idx){
		yield return new WaitWhile (()=> source_m.isPlaying);
		scoreNthings.intru = idx;
		UnityEngine.SceneManagement.SceneManager.LoadScene("Instrucoes");
	}
}
