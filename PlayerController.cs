using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rigidBody2D;
    public float speed = 100f;
    public int coin;

    private float direction;
    public Text CoinUI;


    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        CoinUI.text = coin.ToString();

        rigidBody2D.velocity = Vector2.zero;
        rigidBody2D.velocity = new Vector2(direction * speed * Time.fixedDeltaTime, 0);

        if(coin < 0)
        {
            coin = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D Col)
    {

        if (Col.gameObject.tag == "Obstacle" && coin > 0)
        {
            //GetComponent<Animator>().SetBool("Hit", true);
            //GetComponent<Animator>().SetBool("Hit", false);
            GetComponent<Animator>().Play("HitCar");
            coin = coin - 2;
           

        }
        if (Col.gameObject.tag == "Coin")
        {
            coin++;

        }
    }
}
