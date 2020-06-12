using UnityEngine;
using UnityEngine.UI;

public class getbtn2 : MonoBehaviour {

	Button btns2;

	void Start () {
		btns2 = GetComponent<Button>();
		btns2.onClick.AddListener(btn_nega);
	}

	public void btn_nega(){
	GameObject aaa;
	aaa = GameObject.Find("Pergunta(Clone)");
	Destroy(aaa);
	}	
}
