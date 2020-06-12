using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sair_gui : MonoBehaviour {

	public GameObject gobjc;
	/*
	bool bolo = false;
	Rect menu;

	void Start () {
		int windowWidth = 100;
		int windowHeight = 70;
		int x = (Screen.width - windowWidth) / 2;
		int y = (Screen.height - windowWidth) / 2;
		menu = new Rect(x - 120,y + 85,windowWidth,windowHeight);
	}

	public void truzificar(){
		bolo = true;
	}

	void layout(int i) {
		if(GUILayout.Button("Sim")){
			Application.Quit();
		}
		if(GUILayout.Button("Não")){
			bolo = false;
		}
	}

	public void OnGUI()
	{		
		if (bolo){
		GUI.matrix = Matrix4x4.TRS(new Vector3(-40, 80, 0), Quaternion.identity, new Vector3(1f, 1f, 1));

		GUI.Window(0,menu,layout,"Tem Certeza?");
		}
	}
	*/
	//---------------------------------------------------------------------------------
	public void intace_ui (){
		Instantiate (gobjc);
	}

	//void getar_btns(){
	//	getbtn.btns.onClick.AddListener(btn_aceita);
	//	getbtn2.btns2.onClick.AddListener(btn_nega);
	//}

	}
	
