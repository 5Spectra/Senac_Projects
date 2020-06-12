using UnityEngine;
using UnityEngine.SceneManagement;

public class Troca_cena : MonoBehaviour {

    [SerializeField]
    int go = 0;

    void Update () {

        if (Input.anyKeyDown) {
         //   if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2)) { return; }
                go += 1;
            if (go >= 3) { SceneManager.LoadScene("Game"); }
        }
    }

}
