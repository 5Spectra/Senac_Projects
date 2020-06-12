using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScipt : MonoBehaviour {
	[SerializeField]
	private float valor_atual = 0, valor_max = 100;

	public Image content;
	public Text texto;

	void Start () {
		
	}

	void Update () {
		Handle_Bar(); 
		Verif();

		texto.text = System.String.Format("Health: {0}", valor_atual);

		if (Input.GetKey(KeyCode.P)){ valor_atual += 10;}
		if (Input.GetKey(KeyCode.I)){ valor_atual -= 10;}
	}

	void Handle_Bar()//serve para setar o enchiemento da barra
	{
		content.fillAmount = Map(valor_atual,0,valor_max,0,1);
	}
	private float Map (float value, float inMin, float inMax, float outMin, float outMax)
	{
		value = (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin ;
		return value;

		// é uma conta usada para transformar - sua vida atual em valor de 0 a 1 (outMin a outMax)
		//value = value/inMax tambem ai mas somente se o valor mínimo for 0
		/*
		Value = Valor Atual
		inMin = Valor Mínima
		inMax = Valor Máxima
		outMin = Mínimo do valor a ser convertido
		OutMax = Máximo do valor a ser convertido
		*/
	}
	private void Verif(){
		if (valor_atual > valor_max) valor_atual = valor_max; 
		if (valor_atual < 0) valor_atual = 0;

	}
}
