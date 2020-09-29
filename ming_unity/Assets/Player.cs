using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Animator anim;
    public Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    void movement()
    {
        if (Input.GetAxisRaw("Vertical") != 0)
        {
            rb.velocity = new Vector2(speed , rb.velocity.y);
            anim.SetBool("跑步开关", true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, 8f);
            anim.SetTrigger("跳跃开关");
        }
    }
}
