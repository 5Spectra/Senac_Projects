using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pisca : MonoBehaviour {

	Text flashingText;
	[TextArea(1,3)]
	public string texto;

	void Start(){
		flashingText = GetComponent<Text>();
		StartCoroutine(BlinkText());
	}

	IEnumerator BlinkText (){
		//blink it forever. You can set a terminating condition depending upon your requirement
		while(true){
			flashingText.text= "";
			yield return new WaitForSeconds(.5f);
			flashingText.text= texto;
			yield return new WaitForSeconds(.5f);
		}
	}

}
