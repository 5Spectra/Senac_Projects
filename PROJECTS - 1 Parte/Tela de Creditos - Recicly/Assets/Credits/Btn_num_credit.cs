using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Btn_num_credit : MonoBehaviour
{

    [SerializeField]
    Text txt;

    [SerializeField]
    Image img;

    public Sprite[] fotos;

    // [TextArea()]
    public string[] biografia;

   /* public */ AudioSource audio;

    void Start()
    {
        txt = GameObject.Find("Biografia").GetComponent<Text>();
        img = GameObject.Find("Foto").GetComponent<Image>();
        audio = GetComponent<AudioSource>();
    }

    public void change_person(int person)
    {
        //  if (!audio.isPlaying)
        audio.Play();


        for (int x = 1; x <= 10; x++)
        {
            if (person == x)
            {
                txt.text = biografia[x - 1];
                img.sprite = fotos[x - 1];
            }
        }
    }

    public void Load_cena(string cena)
    {
        audio.Play();
        SceneManager.LoadScene(cena);
    }
}