using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bol1 : MonoBehaviour {

	RaycastHit2D hit;
	public string findertag = "";
	SpriteRenderer sr;
	public Sprite preto;
	GameObject aaa;

	void Start ()
	{
	}

	void Update () {
		
		if (bolinhas.b1 == false) {blacktag ();}
		if (bolinhas.b2 == false) {blacktag ();}
		if (bolinhas.b3 == false) {blacktag ();}
		if (bolinhas.b4 == false) {blacktag ();}
		if (bolinhas.b5 == false) {blacktag ();}
		if (bolinhas.b6 == false) {blacktag ();}
		if (bolinhas.b7 == false) {blacktag ();}
		if (bolinhas.b8 == false) {blacktag ();}
		if (bolinhas.b9 == false) {blacktag ();}
		if (bolinhas.b10 == false) {blacktag ();}
		if (bolinhas.b11 == false) {blacktag ();}
		if (bolinhas.b12 == false) {blacktag ();}
		if (bolinhas.b13 == false) {blacktag ();}
		if (bolinhas.b14 == false) {blacktag ();}
		if (bolinhas.b15 == false) {blacktag ();}
	}

	void blacktag(){
		aaa = GameObject.FindGameObjectWithTag (findertag);
		sr = aaa.GetComponent<SpriteRenderer>();
		sr.sprite = preto;
	}
}
