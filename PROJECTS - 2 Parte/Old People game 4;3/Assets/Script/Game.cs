using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {


    public Image imagem;

    public GameObject[] respostas_off, letras_off, vida_sp;
    public Sprite[] desenhos;

    public GameObject vitoria, derrota;

    public string[] InUse_text;

    Text[] respostas = new Text[5], letras = new Text[12];
    int[] already;

    int sorte, vidas = 3, completar_jogo, ganhar_jogo;

	void Start () {
        already = new int[desenhos.Length];

        for (int x = 0; x < desenhos.Length; x++)
        {
            already[x] = -1;
        }
        
        for (int x = 0; x < letras_off.Length; x++)
        {
            letras[x] = letras_off[x].GetComponentInChildren<Text>();

            if (x < respostas_off.Length)
            respostas[x] = respostas_off[x].GetComponentInChildren<Text>();
        }

        game_start();
    }

    void game_start()
    {
        int tamanho = desenhos.Length;
        sorte = Random.Range(0, tamanho);

        while (already[sorte] != -1) {
           
           sorte = Random.Range(0, tamanho);
        }

        for (int x = 0; x < tamanho; x++)
        {
            if (x == sorte)
            {
                imagem.sprite = desenhos[x];
                break;
            }
        }

            for (int i = 0; i < InUse_text[sorte].Length; i++)
            {
                respostas[i].text = InUse_text[sorte][i].ToString();
            }

            //seta o comando
           // for (int i = 0; i < letrinas[sorte].Length; i++)
            
                //letras[i].text = letrinas[sorte][i].ToString();
                random_texto();
    }
        

    public void btn_check(int num_btn) {

        bool acerto = false;
        string btn_texto = letras[num_btn].text;

        for (int i = 0; i < InUse_text[sorte].Length; i++)
        {
            if (InUse_text[sorte][i].ToString() == btn_texto){
                respostas_off[i].SetActive(true);
                acerto = true;
            }
        }
        
        if (acerto == false){
            vidas -= 1;
            for (int x = 0, i = 2; x < 3; x++, i--)
            {
                if (vidas == i)
                vida_sp[x].SetActive(false);
            }

        }

        if (respostas_off[0].activeSelf && respostas_off[1].activeSelf && respostas_off[2].activeSelf&& respostas_off[3].activeSelf && respostas_off[4].activeSelf)
        {
            ganhar_jogo += 1;
            if (ganhar_jogo == 3)
                SceneManager.LoadScene("ganhar");
            else {
            vitoria.SetActive(true);
            already[sorte] = sorte; //para não repetir a fase
            }
        }
        else if (vidas <= 0)
        {
            derrota.SetActive(true);
        }

        letras_off[num_btn].SetActive(false);
                
    }

    void Reset() {
        vidas = vida_sp.Length;//3

        for (int x = 0; x < letras_off.Length; x++)//12
        {
            letras_off[x].SetActive(true);
            if (x < vidas)
            vida_sp[x].SetActive(true);
            if (x < respostas_off.Length)//5
            respostas_off[x].SetActive(false);
        }
    }

    public void Proximo_continuar() {
        Reset();
        game_start();
        vitoria.SetActive(false);
    }

    void random_texto() {

        string str = "";
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZÇ";

        for (int i = 0; i < letras_off.Length; i++)
        {
            str += chars[Random.Range(0, chars.Length)];
        }
        text_test(str);

    }

    void text_test(string txt) {

        if (txt.Contains(InUse_text[sorte][0].ToString()) == false)
            random_texto();
        else if (txt.Contains(InUse_text[sorte][1].ToString()) == false)
            random_texto();
        else if (txt.Contains(InUse_text[sorte][2].ToString()) == false)
            random_texto();
        else if (txt.Contains(InUse_text[sorte][3].ToString()) == false)
            random_texto();
        else if (txt.Contains(InUse_text[sorte][4].ToString()) == false)
            random_texto();

        else
            for (int i = 0; i < letras_off.Length; i++)
            {
                letras[i].text = txt[i].ToString();
            }        
    }
}
