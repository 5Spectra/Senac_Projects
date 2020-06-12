using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConecBD : MonoBehaviour {

    public InputField frase;
    public Text resposta;
    
    void Start() {
        frase.Select();
    }

	void Update () {

        if (Input.GetKeyDown(KeyCode.F1)) {
            StartCoroutine(testeBD());
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            StartCoroutine(testeSelectDB());
        }

    }

    IEnumerator testeBD() {
        WWWForm formulario = new WWWForm();
        formulario.AddField("teste", frase.text);

        string url = "http://localhost/xampp/unity/teste.php";

        WWW conectaBD = new WWW(url, formulario);

        yield return conectaBD;
        frase.text = "";
        frase.Select();

        print(conectaBD.text);
               
    }

    IEnumerator testeSelectDB() {
        string url = "http://localhost/xampp/unity/select.php";
        WWW conectaBD = new WWW(url);

        yield return conectaBD;
        print(conectaBD.text);
        resposta.text = conectaBD.text;
    }
}
