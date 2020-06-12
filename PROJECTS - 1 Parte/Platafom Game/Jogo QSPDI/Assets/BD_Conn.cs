using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BD_Conn : MonoBehaviour {

    public InputField login_N, login_S;
    public InputField criar_N, criar_S;

    string php_criar = "http://localhost/xampp/Plataforma/Criar_Conta.php";
    string php_logar = "http://localhost/xampp/Plataforma/Logar_Conta.php";


    public void login_check() {
        if (!check_field(login_N.text, login_S.text))
           return;

        StartCoroutine(Logar());
    }

    public void criar_conta() {
        if (!check_field(criar_N.text, criar_S.text))
            return;

        StartCoroutine(Criar());
    }

    bool check_field(string texto_N, string texto_S) {
        int verdade = 0;

        if (texto_N.Length >= 2)
            verdade++;

        if (texto_S.Length >= 2)
            verdade++;

        if (verdade == 2)
            return true;
        else
        {
            print("Erro");
            return false;
        }
    }

    IEnumerator Logar()
    {

        WWWForm form = new WWWForm();

        form.AddField("playerNamePost", login_N.text);
        form.AddField("playerPasswordPost", login_S.text);

        WWW www = new WWW(php_logar, form);

        yield return www;

        if (www.text == "-1")
            print("Senha Errada");
        else if (www.text == "0")
            print("Usuario Errado");
        else {
            All_class.playerN = login_N.text;
            Proxima_Cena("Level_1");
        }
    }

    IEnumerator Criar()
    {
        WWWForm form = new WWWForm();

        form.AddField("playerNameCreate", criar_N.text);
        form.AddField("playerPasswordCreate", criar_S.text);

        WWW www = new WWW(php_criar, form);

        yield return www;

        if (www.text == "Erro")
            print("Algo deu Errado");
        else
        {
            All_class.playerN = criar_N.text;
            Proxima_Cena("Level_1");
        }
   }


    void Proxima_Cena(string cena) {
       UnityEngine.SceneManagement.SceneManager.LoadScene(cena);
    }

}
