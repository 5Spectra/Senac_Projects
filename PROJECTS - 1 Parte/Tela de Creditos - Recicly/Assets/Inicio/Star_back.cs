using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_back : MonoBehaviour {

    public float x, y, z;

	void Update () {
        var rc = gameObject.GetComponent<Star_back>();

        if (transform.position.z <= -90)
            rc.enabled = !enabled;
        else
            transform.Translate(x, y, z);
    }
}
