using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slime : MonoBehaviour
{

    Rigidbody2D rb;
    SpriteRenderer sp;
    Animator anim;
    public int speed;

    public Text coin_txt, player_txt;

    [SerializeField]
    bool isFalling = false, isDashing = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>(); //Parado 0//Movendo 1//Pulando bool
        player_txt.text = All_class.playerN;
        StartCoroutine(wait_BD());
    }

    void Update()
    {

        float translation_h = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        float translation_v = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        if (translation_h > 0)
        {
            transform.Translate(translation_h, 0, 0);
            sp.flipX = true;
        }
        else if (translation_h < 0)
        {
            transform.Translate(translation_h, 0, 0);
            sp.flipX = false;
        }

        if (translation_v > 0 && isFalling == false)
        {
            rb.AddForce(Vector3.up * speed);
            isFalling = true;
            anim.SetBool("Pulando", true);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isDashing == true)
        {
            isDashing = false;
            StartCoroutine(dash());
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "terreno" && isFalling == true)
        {
            anim.SetBool("Pulando", false);
            isFalling = false;
        }

        if (coll.gameObject.tag == "pena")
        {
            rb.AddForce(Vector3.up * speed * 3);
        }
    }

    void OnTriggerEnter2D(Collider2D tcol)
    {
        if (tcol.gameObject.tag.Equals("moeda"))
        {
            All_class.coins += 1;
            coin_txt.text = "Moedas: " + All_class.coins.ToString();
            Destroy(tcol.gameObject);
        }
    }

    IEnumerator dash()
    {
        if (sp.flipX)
            rb.AddForce(Vector3.right * 40);
        else
            rb.AddForce(Vector3.left * 40);

        yield return new WaitForSecondsRealtime(1);
        isDashing = true;
    }

    IEnumerator wait_BD()
    {
        yield return new WaitForSeconds(0.5f);
        coin_txt.text = "Moedas: " + All_class.coins.ToString();
    }
}
