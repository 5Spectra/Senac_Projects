using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getgobj : MonoBehaviour {

	public static GameObject gamer;

	void Start () {
		gamer = GetComponent<GameObject>();
	}
}
