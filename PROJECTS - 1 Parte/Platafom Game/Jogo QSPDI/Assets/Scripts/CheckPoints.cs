using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour {

    Animator anim;
    bool chekpoint;
    Transform player_pos;

    public GameObject limite, player_slime;

    string php_moeda_set = "http://localhost/xampp/Plataforma/Set_Moedas.php";

    void Start()
    {
       //player_slime.transform.position = limite.transform.position;
        anim = GetComponent<Animator>();
    }


    void OnTriggerEnter2D(Collider2D tcol)
    {

        if (tcol.gameObject.tag.Equals("Player"))
        {
            anim.SetBool("Passou", true);
            player_pos = tcol.gameObject.transform;
            StartCoroutine(moeda_set());
            limite.SetActive(true);
        }
    }

    IEnumerator moeda_set()
    {
        WWWForm form = new WWWForm();

        form.AddField("nomeJogador", All_class.playerN);
        form.AddField("numMoedas", All_class.coins);

        WWW www = new WWW(php_moeda_set, form);

        yield return www;

        print(www.text);
    }

}
