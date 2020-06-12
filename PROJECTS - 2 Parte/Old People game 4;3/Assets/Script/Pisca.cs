using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pisca : MonoBehaviour {

    Text flashingText;

    void Start(){
            flashingText = GetComponent<Text>();
            StartCoroutine(BlinkText());
        }

  //function to blink the text
    public IEnumerator BlinkText()
    {
        while (true)
        {
            flashingText.text = "";
            yield return new WaitForSeconds(0.7f);
            flashingText.text = "Pressione qualquer tecla 3x para começar";
           yield return new WaitForSeconds(2.5f);
        }
    }
}
