using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hello : MonoBehaviour {

	public Image black;
	public Animator anim;

	void Update () {
		if (Input.anyKey){
			StartCoroutine(fade());
		}
	}

	IEnumerator fade(){
		anim.SetBool("Fade", true);
		yield return new WaitUntil(()=>black.color.a == 1);
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Menu");
	}
}
