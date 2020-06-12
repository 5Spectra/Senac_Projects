using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour {

    public Transform posA, posB;
    public GameObject plataforma;
    public bool volta;

	void Start () {
	}

    void Update() {

        var plat = plataforma.transform.position;
        var A = posA.position;
        var B = posB.position;

        if (plat == A)
           volta = false;
        else if (plat == B)
          volta = true;

        if (volta == false)
        plataforma.transform.position = Vector3.MoveTowards(plat, B, 2 * Time.deltaTime);
        else if (volta == true)
        plataforma.transform.position = Vector3.MoveTowards(plat, A, 2 * Time.deltaTime);

    }
}
