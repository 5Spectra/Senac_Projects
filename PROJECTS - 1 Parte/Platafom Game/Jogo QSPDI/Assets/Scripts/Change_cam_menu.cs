using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_cam_menu : MonoBehaviour {

    public GameObject camera_obj;

	public void Change_for_menu (string cena) {
            SceneManager.LoadScene(cena);
	}

    public void Change_cameraY(float roteY) {
		camera_obj.transform.Rotate(0, roteY, 0);
    }
    public void Change_cameraX(float roteX)
    {
		camera_obj.transform.Rotate(roteX, 0, 0);
    }

    public void cam_reset() {
		camera_obj.transform.Rotate(new Vector3(0, 0, 0));
    }

    public void Exit(){
        Application.Quit();
    }
}
