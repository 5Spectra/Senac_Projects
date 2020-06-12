using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pisca : MonoBehaviour {

    Text flashingText;

    [TextArea(1, 2)]
    public string Texto; 


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
            yield return new WaitForSeconds(1f);
            flashingText.text = Texto;
           yield return new WaitForSeconds(1f);
        }
    }
}
