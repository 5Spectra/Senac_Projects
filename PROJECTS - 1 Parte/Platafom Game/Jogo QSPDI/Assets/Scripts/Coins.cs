using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour {



	void Start(){
		
	}

    void OnTriggerEnter2D(Collider2D tcol)
    {

		if (tcol.gameObject.tag.Equals("Player"))
		{
			//script.coins += 1;
			//script.set_moedas ();
			Destroy(gameObject);
		}

    }
}
