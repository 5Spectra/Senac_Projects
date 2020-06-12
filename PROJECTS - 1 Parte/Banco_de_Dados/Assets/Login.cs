using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{

    public InputField userName, userPassword;
    public Button btnaLogin;

    public void userLog()
    {
        StartCoroutine(loginDB());
    }

    IEnumerator loginDB()
    {
        string url = "http://localhost/xampp/unity/login.php";

        WWWForm f = new WWWForm();
        f.AddField("userName", userName.text);
        f.AddField("userPassword", userPassword.text);

        WWW conectaBD = new WWW(url, f);
        yield return conectaBD;

        int resp = int.Parse(conectaBD.text);

        switch (resp)
        {
            case 0:
                print(resp);
                //SceneManager.LoadScene("erro");
                break;
            case 1:
                print(resp);
                //SceneManager.LoadScene("logado");
                break;
        }
    }
}
