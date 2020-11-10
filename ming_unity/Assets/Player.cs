using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Animator anim;
    public Rigidbody2D rb;

    public float speed;
    public float jumpForce;
    float horizontalMove;
    bool isJump;

    public GameObject final;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJump = true;
        }


    }
    private void FixedUpdate()
    {
        movement();
        jump();
    }

    void movement()
    {


        rb.velocity = new Vector2(horizontalMove * speed, rb.velocity.y);

        if (Mathf.Abs(horizontalMove) != 0)
        {
            rb.transform.localScale = new Vector3(horizontalMove * 1, 1, 1);
        }



    }

    void jump()
    {
        if (isJump==true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isJump = false;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Door")
        {
            final.SetActive(true);
        }
        
    }
}
