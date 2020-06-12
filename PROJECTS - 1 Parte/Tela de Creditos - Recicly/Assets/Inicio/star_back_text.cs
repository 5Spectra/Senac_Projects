using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class star_back_text : MonoBehaviour
{
    public string cena;

    void Update()
    {

        if (Input.anyKeyDown) {
            SceneManager.LoadScene(cena);
        }


        if (transform.position.z <= -50)
            transform.Translate(0, 0.04f, 0);

        else if (transform.position.z <= -45)
            transform.Translate(0, 0.06f, 0);
        
        else if (transform.position.z <= -40)
            transform.Translate(0, 0.08f, 0);

        else if (transform.position.z <= -35)
            transform.Translate(0, 0.09f, 0);

        else if (transform.position.z <= -30)
            transform.Translate(0, 0.1f, 0);

        else if (transform.position.z <= -25)
            transform.Translate(0, 0.11f, 0);

        else if (transform.position.z <= -13)
            transform.Translate(0, 0.12f, 0);

        else if (transform.position.z <= -0)
            transform.Translate(0, 0.13f, 0);

        else if (transform.position.z >= 190)
            SceneManager.LoadScene(cena);

        else
            transform.Translate(0, 0.14f, 0);

    }
}
