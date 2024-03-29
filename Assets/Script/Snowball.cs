using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour
{

    public float ballSpeed;

    private Rigidbody2D rigid;

    public GameObject snowBallEffect;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.velocity = new Vector2(ballSpeed * transform.localScale.x, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player 1")
        {
            FindObjectOfType<GameManager>().HurtP1();
        }
        
        if(other.tag == "Player 2")
        {
            FindObjectOfType<GameManager>().HurtP2();
        }

        Instantiate(snowBallEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
