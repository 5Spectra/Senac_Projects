using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolinhas : MonoBehaviour {

	RaycastHit2D hit;
	string tang, n;
	public static bool b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14, b15;
	SpriteRenderer sr;
	int num;
	public Sprite preto, red;
	GameObject aaa, linha;
	string[] b = new string[16];

	void Awake () {
		num = Random.Range (1,16);
		for (int i = 1; i < 16;i++)
		{
			b[i] = string.Concat("b",i);
			n = string.Concat("t",num);
		}
		Debug.Log(num + " " + Time.deltaTime);
		b1 = true;
	}//Random.Range (1,16)

	void Start ()
	{	Debug.Log(num);	
	}
		
		void Update () {
			if (Input.GetMouseButtonDown (0)) {
				hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);
				
			//b1------ 2 7
				if (hit.collider != null && hit.transform.gameObject.tag == "b2" && b1 == true) {
				tang = "b2";
				verif(); verm ();
				b1 = false; b2 = true;
				}
				if (hit.collider != null && hit.transform.gameObject.tag == "b7" && b1 == true) {
				tang = "b7";
				verif(); verm (); 
				b1 = false;	b7 = true;
				}
		
		//b2------ 1 3 8				
			if (hit.collider != null && hit.transform.gameObject.tag == "b3" && b2 == true) {				
				tang = "b3";
				verif();	verm ();
				b2 = false;	b3 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b8" && b2 == true) {		
				tang = "b8";
				verif();	verm ();
				b2 = false;	b8 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b1" && b2 == true) {		
				tang = "b1";
				verif();	verm ();
				b2 = false;	b1 = true;	}
			
		//b3------2 9
			if (hit.collider != null && hit.transform.gameObject.tag == "b2" && b3 == true) {		
				tang = "b2";
				verif();verm ();
				b3 = false;	b2 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b9" && b3 == true) {		
				tang = "b9"; 
				verif();verm ();
				b3 = false;	b9 = true;	}
			
		//b4------ 5 9
			if (hit.collider != null && hit.transform.gameObject.tag == "b5" && b4 == true) {		
				tang = "b5";
				verif();verm ();
				b4 = false;	b5 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b9" && b4 == true) {		
				tang = "b9";
				verif();verm ();
				b4 = false;	b9 = true;	}
		
		//b5------ 4 6 10
			if (hit.collider != null && hit.transform.gameObject.tag == "b4" && b5 == true) {		
				tang = "b4";
				verif();verm ();
				b5 = false;	b4 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b6" && b5 == true) {		
				tang = "b6"; 
				verif();verm ();
				b5 = false;	b6 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b10" && b5 == true) {		
				tang = "b10"; 
				verif();verm ();
				b5 = false;	b10 = true;	}
		//b6------ 11 5
			if (hit.collider != null && hit.transform.gameObject.tag == "b11" && b6 == true) {		
				tang = "b11"; 
				verif();verm ();
				b6 = false;	b11 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b5" && b6 == true) {		
				tang = "b5";
				verif();verm ();
				b6 = false;	b5 = true;	}
		//b7------ 1 8 14
			if (hit.collider != null && hit.transform.gameObject.tag == "b1" && b7 == true) {		
				tang = "b1";
				verif();verm ();
				b7 = false;	b1 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b8" && b7 == true) {		
				tang = "b8";
				verif();verm ();
				b7 = false;	b8 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b14" && b7 == true) {		
				tang = "b14";
				verif();verm ();
				b7 = false;	b14 = true;	}
		//b8------ 2 7 9
			if (hit.collider != null && hit.transform.gameObject.tag == "b2" && b8 == true) {		
				tang = "b2";
				verif();verm ();
				b8 = false;	b2 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b7" && b8 == true) {		
				tang = "b7";
				verif();verm ();
				b8 = false;	b7 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b9" && b8 == true) {		
				tang = "b9";
				verif();verm ();
				b8 = false;	b9 = true;	}
			
		//b9------ 3 4 8 10 13
			if (hit.collider != null && hit.transform.gameObject.tag == "b3" && b9 == true) {		
				tang = "b3";
				verif();verm ();
				b9 = false;	b3 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b4" && b9 == true) {		
				tang = "b4";
				verif();verm ();
				b9 = false;	b4 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b8" && b9 == true) {		
				tang = "b8";
				verif();verm ();
				b9 = false;	b8 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b10" && b9 == true) {		
				tang = "b10";
				verif();verm ();
				b9 = false;	b10 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b13" && b9 == true) {		
				tang = "b13";
				verif();verm ();
				b9 = false;	b13 = true;	}
			
		//b10----- 5 9 11
			if (hit.collider != null && hit.transform.gameObject.tag == "b5" && b10 == true) {		
				tang = "b5";
				verif();verm ();
				b10 = false;	b5 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b9" && b10 == true) {		
				tang = "b9";
				verif();verm ();
				b10 = false;	b9 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b11" && b10 == true) {		
				tang = "b11";
				verif();verm ();
				b10 = false;	b11 = true;	}
			
		//b11----- 6 10 12
			if (hit.collider != null && hit.transform.gameObject.tag == "b6" && b11 == true) {		
				tang = "b6";
				verif();verm ();
				b11 = false;	b6 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b10" && b11 == true) {		
				tang = "b10";
				verif();verm ();
				b11 = false;	b10 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b12" && b11 == true) {		
				tang = "b12";
				verif();verm ();
				b11 = false;	b12 = true;	}
			
		//b12----- 11 13 15
			if (hit.collider != null && hit.transform.gameObject.tag == "b11" && b12 == true) {		
				tang = "b11";
				verif();verm ();
				b12 = false;	b11 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b13" && b12 == true) {		
				tang = "b13";
				verif();verm ();
				b12 = false;	b13 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b15" && b12 == true) {		
				tang = "b15";
				verif();verm ();
				b12 = false;	b15 = true;	}
			
		//b13----- 9 12 14
			if (hit.collider != null && hit.transform.gameObject.tag == "b9" && b13 == true) {		
				tang = "b9";
				verif();verm ();
				b13 = false;	b9 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b12" && b13 == true) {		
				tang = "b12";
				verif();verm ();
				b13 = false;	b12 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b14" && b13 == true) {		
				tang = "b14";
				verif();verm ();
				b13 = false;	b14 = true;	}
			
		//b14----- 7 13 15
			if (hit.collider != null && hit.transform.gameObject.tag == "b7" && b14 == true) {		
				tang = "b7";
				verif();verm ();
				b14 = false;	b7 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b13" && b14 == true) {		
				tang = "b13";
				verif();verm ();
				b14 = false;	b13 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b15" && b14 == true) {		
				tang = "b15";
				verif();verm ();
				b14 = false;	b15 = true;	}
			
		//b15----- 12 14
			if (hit.collider != null && hit.transform.gameObject.tag == "b12" && b15 == true) {		
				tang = "b12";
				verif();verm ();
				b15 = false;	b12 = true;	}
			if (hit.collider != null && hit.transform.gameObject.tag == "b14" && b15 == true) {		
				tang = "b14";
				verif();verm ();
				b15 = false;	b14 = true;	}

	}
}
	void verm(){
		howtowin();
		aaa = GameObject.FindGameObjectWithTag(tang);
		sr = aaa.GetComponent<SpriteRenderer>();
		sr.sprite = red;}
	
	void verif(){
		if (b1 == false) {blacktag ();}
		if (b2 == false) {blacktag ();}
		if (b3 == false) {blacktag ();}
		if (b4 == false) {blacktag ();}
		if (b5 == false) {blacktag ();}
		if (b6 == false) {blacktag ();}
		if (b7 == false) {blacktag ();}
		if (b8 == false) {blacktag ();}
		if (b9 == false) {blacktag ();}
		if (b10 == false) {blacktag ();}
		if (b11 == false) {blacktag ();}
		if (b12 == false) {blacktag ();}
		if (b13 == false) {blacktag ();}
		if (b14 == false) {blacktag ();}
		if (b15 == false) {blacktag ();}
	}

	void blacktag(){
		for (int i = 1; i < 16; i++){
		aaa = GameObject.FindGameObjectWithTag (b[i]);
		sr = aaa.GetComponent<SpriteRenderer>();
		sr.sprite = preto;
		}
	}
	void howtowin(){
		for (int i = 1; i < 16;i++)
			if (b[i] == n){ Debug.Log("Vitoria"); }
	}
	void vai(){
		
		for (int i = 1; i < 16;i++){
		 
			b[i] = string.Concat("b",i);
			n = string.Concat("t",num);
		}
		Debug.Log(num + " " + Time.deltaTime);
		b1 = true;
	}
}










