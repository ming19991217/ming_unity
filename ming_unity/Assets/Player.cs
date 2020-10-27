using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Animator anim;
    public Rigidbody2D rb;
    public float speed;
    float y;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        y = Input.GetAxis("Horizontal");
        
     
    }
    private void FixedUpdate()
    {
        movement();
    }

    void movement()
    {
        rb.velocity = new Vector2(y * speed,rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(0f, jumpForce);
            
        }  
      
    }
}
