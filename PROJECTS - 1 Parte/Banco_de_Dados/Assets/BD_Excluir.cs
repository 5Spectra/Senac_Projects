using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BD_Excluir : MonoBehaviour {

    public string deletar;

	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            StartCoroutine(removerUser());
        }
	}
	
	IEnumerator removerUser(){
		WWWForm formulario = new WWWForm();
		formulario.AddField ("user", deletar);
		WWW site = new WWW ("http://10.125.44.26/unity/excluir.php", formulario);//10.125.44.26
        yield return site;

        print(site.text);
	}
}
