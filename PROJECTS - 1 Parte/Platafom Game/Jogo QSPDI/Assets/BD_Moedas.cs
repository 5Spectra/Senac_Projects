using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BD_Moedas : MonoBehaviour {


    string php_moeda_get = "http://localhost/xampp/Plataforma/Get_Moedas.php";
    string php_moeda_set = "http://localhost/xampp/Plataforma/Set_Moedas.php";

    void Start () {
        StartCoroutine(moeda_get());
	}

    IEnumerator moeda_get()
    {
        WWWForm form = new WWWForm();

        form.AddField("nomeJogador", All_class.playerN);

        WWW www = new WWW(php_moeda_get, form);

        yield return www;

        All_class.coins = int.Parse(www.text);
    }
    /*
   IEnumerator moeda_set()
    {
        WWWForm form = new WWWForm();

        form.AddField("nomeJogador", All_class.playerN);
        form.AddField("numMoedas", All_class.coins);

        WWW www = new WWW(php_moeda_set, form);

        yield return www;

        print(www.text);
    }
    */
}
