using UnityEngine;
using UnityEngine.UI;

public class getbtn : MonoBehaviour {

	public static Button btns;

	void Start () {
		btns = GetComponent<Button>();
		btns.onClick.AddListener(btn_aceita);
	}

	public static void btn_aceita(){		
		Application.Quit();
	}
}
