using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Movement : MonoBehaviour
{
    public float direction;
    public float speed;
    public Rigidbody2D rigidBody2D;
    [Range(0, 60)]
    public float timeToDestroy;
    public bool ifCoin;
    public GameObject Particle;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody2D.velocity = new Vector2(0, direction * speed * Time.fixedDeltaTime);

    }
    void OnTriggerEnter2D(Collider2D Col)
    {

        if (Col.gameObject.tag == "Player" && ifCoin)
        {
            Destroy(gameObject);
            Instantiate(Particle, transform.position, Quaternion.identity);

        }

    }
}