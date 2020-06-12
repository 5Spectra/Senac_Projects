using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits_digits : MonoBehaviour
{

    Btn_num_credit sn;

   //string[] keys = { "1", "2", "3", "4", "5", "6", "7", "8", "9","0" };

    void Start() {
        sn = gameObject.GetComponent<Btn_num_credit>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) { sn.change_person(1);}
        if (Input.GetKeyDown(KeyCode.Alpha2)) { sn.change_person(2); }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { sn.change_person(3); }
        if (Input.GetKeyDown(KeyCode.Alpha4)) { sn.change_person(4); }
        if (Input.GetKeyDown(KeyCode.Alpha5)) { sn.change_person(5); }
        if (Input.GetKeyDown(KeyCode.Alpha6)) { sn.change_person(6); }
        if (Input.GetKeyDown(KeyCode.Alpha7)) { sn.change_person(7); }
        if (Input.GetKeyDown(KeyCode.Alpha8)) { sn.change_person(8); }
        if (Input.GetKeyDown(KeyCode.Alpha9)) { sn.change_person(9); }
        if (Input.GetKeyDown(KeyCode.Alpha0)) { sn.change_person(10); }
    }
}
