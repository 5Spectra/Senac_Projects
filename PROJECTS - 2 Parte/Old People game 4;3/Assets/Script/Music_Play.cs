using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Music_Play : MonoBehaviour {

	public AudioClip song1, song2, won_song;
	AudioSource music;

	void Awake () {
		DontDestroyOnLoad(gameObject);
	}

	void Start () {
		UnityEngine.SceneManagement.SceneManager.LoadScene("Tutorial");
		music = GetComponent<AudioSource> ();
	}

	void FixedUpdate(){

		if (!music.isPlaying)
			StartCoroutine (playing(music.clip));
			
	}

	IEnumerator playing(AudioClip musica){
		Scene cena_atual = SceneManager.GetActiveScene();
		string nome_cena = cena_atual.name;

		if (nome_cena == "Ganhar") {
			music.clip = won_song;
		}

		music.Play ();

		yield return new WaitForSeconds (musica.length);

		if (musica == song1) {
			music.volume = 0.6f;
			music.clip = song2;
		} 

		else if (musica == song2){
			music.volume = 1;
			music.clip = song1;
		}
	}

}
