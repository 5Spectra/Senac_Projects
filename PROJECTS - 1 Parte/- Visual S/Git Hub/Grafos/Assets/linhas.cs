using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linhas : MonoBehaviour {
	GameObject linha1,linha2,linha3,linha4,linha5;
	string litag1, litag2, litag3, litag4, litag5;
	GameObject[] linha = new GameObject[22];
	static string[] a = new string[22] ;
	SpriteRenderer sr, sr1, sr2, sr3, sr4, sr5;
	public Sprite linhas_s;

	void Start () {			
			for (int i = 1; i < 22; i++){
			a[i] = string.Concat("t",i);
			linha[i] = GameObject.FindGameObjectWithTag (a[i]);
			//linha[i].SetActive(false);
			sr = linha[i].GetComponent<SpriteRenderer>();
			sr.sprite = null;
		}
	}
		
	void Update () {if(Input.GetKeyDown(KeyCode.A)){Debug.Log("a");bol1();}

		if (bolinhas.b1 == true){bol1();}//2
		if (bolinhas.b2 == true){bol2();}//3
		if (bolinhas.b3 == true){bol3();}//2
		if (bolinhas.b4 == true){bol4();}//2
		if (bolinhas.b5 == true){bol5();}//3
		if (bolinhas.b6 == true){bol6();}//2
		if (bolinhas.b7 == true){bol7();}//3
		if (bolinhas.b8 == true){bol8();}//3
		if (bolinhas.b9 == true){bol9();}//5
		if (bolinhas.b10 == true){bol10();}//3
		if (bolinhas.b11 == true){bol11();}//3
		if (bolinhas.b12 == true){bol12();}//3
		if (bolinhas.b13 == true){bol13();}//3
		if (bolinhas.b14 == true){bol14();}//3
		if (bolinhas.b15 == true){bol15();}//2
	
	}
	/*
	void ativar(){
		if (litag1 != ""){
			linha1 = GameObject.FindGameObjectWithTag (litag1);
			linha1.SetActive(true); deslitag();}
		if (litag2 != ""){
			linha2 = GameObject.FindGameObjectWithTag (litag2);
			linha2.SetActive(true); deslitag();}
		if (litag3 != ""){
			linha3 = GameObject.FindGameObjectWithTag (litag3);
			linha3.SetActive(true); deslitag();}
		if (litag4 != ""){
			linha4 = GameObject.FindGameObjectWithTag (litag4);
			linha4.SetActive(true); deslitag();}
		if (litag5 != ""){
			linha5 = GameObject.FindGameObjectWithTag (litag5);
			linha5.SetActive(true); deslitag();}
	}
	void deslitag(){ litag1 = ""; litag2 = ""; litag3 = ""; litag4 = ""; litag5 = "";}*/






	void bol1(){
		linha1 = GameObject.FindGameObjectWithTag ("t1");
		linha2 = GameObject.FindGameObjectWithTag ("t2");
		sr1 = linha1.GetComponent<SpriteRenderer>();
		sr2 = linha2.GetComponent<SpriteRenderer>();
		sr1.sprite = linhas_s;
		sr2.sprite = linhas_s;
	}
	void bol2(){		
		linha1 = GameObject.FindGameObjectWithTag ("t2");
		linha2 = GameObject.FindGameObjectWithTag ("t3");
		linha3 = GameObject.FindGameObjectWithTag ("t4");
		sr1 = linha1.GetComponent<SpriteRenderer>();
		sr2 = linha2.GetComponent<SpriteRenderer>();
		sr3 = linha2.GetComponent<SpriteRenderer>();
		sr1.sprite = linhas_s;
		sr2.sprite = linhas_s;
		sr3.sprite = linhas_s;
	}
	void bol3(){		
		linha1 = GameObject.FindGameObjectWithTag ("t4");
		linha2 = GameObject.FindGameObjectWithTag ("t5");
		sr1 = linha1.GetComponent<SpriteRenderer>();
		sr2 = linha2.GetComponent<SpriteRenderer>();
		sr1.sprite = linhas_s;
		sr2.sprite = linhas_s;
	}
	void bol4(){		
		linha1 = GameObject.FindGameObjectWithTag ("t6");
		linha2 = GameObject.FindGameObjectWithTag ("t7");
		sr1 = linha1.GetComponent<SpriteRenderer>();
		sr2 = linha2.GetComponent<SpriteRenderer>();
		sr1.sprite = linhas_s;
		sr2.sprite = linhas_s;
	}
	void bol5(){		
		linha1 = GameObject.FindGameObjectWithTag ("t7");
		linha2 = GameObject.FindGameObjectWithTag ("t8");
		linha3 = GameObject.FindGameObjectWithTag ("t9");
		sr1 = linha1.GetComponent<SpriteRenderer>();
		sr2 = linha2.GetComponent<SpriteRenderer>();
		sr1.sprite = linhas_s;
		sr2.sprite = linhas_s;
	}
	void bol6(){		
		linha1 = GameObject.FindGameObjectWithTag ("t9");
		linha2 = GameObject.FindGameObjectWithTag ("t10");
		sr1 = linha1.GetComponent<SpriteRenderer>();
		sr2 = linha2.GetComponent<SpriteRenderer>();
		sr1.sprite = linhas_s;
		sr2.sprite = linhas_s;
	}
	void bol7(){		
		linha1 = GameObject.FindGameObjectWithTag ("t1");
		linha2 = GameObject.FindGameObjectWithTag ("t14");
		linha3 = GameObject.FindGameObjectWithTag ("t15");
		sr1 = linha1.GetComponent<SpriteRenderer>();
		sr2 = linha2.GetComponent<SpriteRenderer>();
		sr3 = linha3.GetComponent<SpriteRenderer>();
		sr1.sprite = linhas_s;
		sr2.sprite = linhas_s;
		sr3.sprite = linhas_s;
		}
	void bol8(){		
		linha1 = GameObject.FindGameObjectWithTag ("t14");
		linha2 = GameObject.FindGameObjectWithTag ("t3");
		linha3 = GameObject.FindGameObjectWithTag ("t13");
		sr1 = linha1.GetComponent<SpriteRenderer>();
		sr2 = linha2.GetComponent<SpriteRenderer>();
		sr3 = linha3.GetComponent<SpriteRenderer>();
		sr1.sprite = linhas_s;
		sr2.sprite = linhas_s;
		sr3.sprite = linhas_s;
		}
	void bol9(){		
		linha1 = GameObject.FindGameObjectWithTag ("t5");
		linha2 = GameObject.FindGameObjectWithTag ("t6");
		linha3 = GameObject.FindGameObjectWithTag ("t13");
		linha4 = GameObject.FindGameObjectWithTag ("t12");
		linha5 = GameObject.FindGameObjectWithTag ("t16");
		sr1 = linha1.GetComponent<SpriteRenderer>();
		sr2 = linha2.GetComponent<SpriteRenderer>();
		sr3 = linha3.GetComponent<SpriteRenderer>();
		sr4 = linha4.GetComponent<SpriteRenderer>();
		sr5 = linha5.GetComponent<SpriteRenderer>();
		sr1.sprite = linhas_s;
		sr2.sprite = linhas_s;
		sr3.sprite = linhas_s;
		sr4.sprite = linhas_s;
		sr5.sprite = linhas_s;
	}
	void bol10(){		
		linha1 = GameObject.FindGameObjectWithTag ("t12");
		linha2 = GameObject.FindGameObjectWithTag ("t8");
		linha3 = GameObject.FindGameObjectWithTag ("t11");
		sr1 = linha1.GetComponent<SpriteRenderer>();
		sr2 = linha2.GetComponent<SpriteRenderer>();
		sr3 = linha3.GetComponent<SpriteRenderer>();
		sr1.sprite = linhas_s;
		sr2.sprite = linhas_s;
		sr3.sprite = linhas_s;
		}
	void bol11(){		
		linha1 = GameObject.FindGameObjectWithTag ("t10");
		linha2 = GameObject.FindGameObjectWithTag ("t11");
		linha3 = GameObject.FindGameObjectWithTag ("t17");
		sr1 = linha1.GetComponent<SpriteRenderer>();
		sr2 = linha2.GetComponent<SpriteRenderer>();
		sr3 = linha3.GetComponent<SpriteRenderer>();
		sr1.sprite = linhas_s;
		sr2.sprite = linhas_s;
		sr3.sprite = linhas_s;
		}
	void bol12(){		
		linha1 = GameObject.FindGameObjectWithTag ("t17");
		linha2 = GameObject.FindGameObjectWithTag ("t18");
		linha3 = GameObject.FindGameObjectWithTag ("t21");
		sr1 = linha1.GetComponent<SpriteRenderer>();
		sr2 = linha2.GetComponent<SpriteRenderer>();
		sr3 = linha3.GetComponent<SpriteRenderer>();
		sr1.sprite = linhas_s;
		sr2.sprite = linhas_s;
		sr3.sprite = linhas_s;
		}
	void bol13(){		
		linha1 = GameObject.FindGameObjectWithTag ("t16");
		linha2 = GameObject.FindGameObjectWithTag ("t18");
		linha3 = GameObject.FindGameObjectWithTag ("t19");
		sr1 = linha1.GetComponent<SpriteRenderer>();
		sr2 = linha2.GetComponent<SpriteRenderer>();
		sr3 = linha3.GetComponent<SpriteRenderer>();
		sr1.sprite = linhas_s;
		sr2.sprite = linhas_s;
		sr3.sprite = linhas_s;
		}
	void bol14(){		
		linha1 = GameObject.FindGameObjectWithTag ("t15");
		linha2 = GameObject.FindGameObjectWithTag ("t19");
		linha3 = GameObject.FindGameObjectWithTag ("t20");
		sr1 = linha1.GetComponent<SpriteRenderer>();
		sr2 = linha2.GetComponent<SpriteRenderer>();
		sr3 = linha3.GetComponent<SpriteRenderer>();
		sr1.sprite = linhas_s;
		sr2.sprite = linhas_s;
		sr3.sprite = linhas_s;
		}
	void bol15(){		
		linha1 = GameObject.FindGameObjectWithTag ("t20");
		linha2 = GameObject.FindGameObjectWithTag ("t21");
		sr1 = linha1.GetComponent<SpriteRenderer>();
		sr2 = linha2.GetComponent<SpriteRenderer>();
		sr3 = linha3.GetComponent<SpriteRenderer>();
		sr1.sprite = linhas_s;
		sr2.sprite = linhas_s;
		sr3.sprite = linhas_s;
		}



}
