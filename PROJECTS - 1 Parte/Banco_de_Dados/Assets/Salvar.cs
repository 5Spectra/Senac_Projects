using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Salvar : MonoBehaviour {

	void Update () {
		
	}

    void Start(){
        StartCoroutine(salvaBD());
    }

    IEnumerator salvaBD() {

        Scene cena = SceneManager.GetActiveScene();

        string url = "http://localhost/unity/update.php";

        WWWForm f = new WWWForm();

        f.AddField("userID", "1");
        f.AddField("userCena", cena.name);
        f.AddField("userPontos", "85");

        WWW conectaBD = new WWW(url, f);
        yield return conectaBD;

    }
}
