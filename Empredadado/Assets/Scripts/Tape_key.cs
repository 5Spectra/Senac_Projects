using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tape_key : MonoBehaviour {

	[TextArea(2,10)]
	public string hist;

	public Text carvatxt;
	public AudioSource source;

	void Start () {
		StartCoroutine(TypeDialogue(hist));
	}

	void Update() {
		if (Input.anyKey)
			UnityEngine.SceneManagement.SceneManager.LoadScene("fase1");
	}
	
	IEnumerator TypeDialogue (string dialogue) {
		yield return new WaitForSeconds (2f);
		bool playSound = true;
		foreach (char letter in hist.ToCharArray()) {
			carvatxt.text += letter;

			if (playSound)
				source.Play();

			playSound = !playSound;

			yield return null;	
			}
	}
}
