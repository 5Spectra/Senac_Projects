using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Floor : MonoBehaviour {

    public GameObject cam, hero;

    bool checkpoint1;

	void Update () {

        float x = hero.transform.position.x;
        float y = hero.transform.position.y;

        // camera seguir
        if (y < 0.49)
            cam_transform(0, 0);
        else if (y > 0.49 && y < 1.41)
            cam_transform(0, 1.5f);
        else if (y > 1.41 && y < 3.46)
            cam_transform(0, 2.5f);
        else if (y > 3.46 && y < 5.65)
            cam_transform(0, 4.5f);

        else if (y > 5.65 && y < 7.2)
            cam_transform(0, 6f);
        else if (y > 7.2 && y < 8.6)
            cam_transform(0, 7.5f);
        else if (y > 8.6  && y < 10)
            cam_transform(0, 8.5f);
    }


    void cam_transform(float x, float y){
        cam.transform.position = new Vector3(x, y, cam.transform.position.z);
    }
}
