using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Cods : MonoBehaviour {


    public void Sair()
    {
		Application.Quit();
    }
    public void Tentar_novamente(string cena)
    {
        SceneManager.LoadScene(cena);
    }
}
