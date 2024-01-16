//HCS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour

// Reference to the SpriteRenderer component
{
    Rigidbody2D myRigidbody;
    SpriteRenderer spriteRenderer;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component
        transform.position = new Vector3(0, -26, 0);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && myRigidbody.velocity.y == 0)
        {
            myRigidbody.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        }
    }
    

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput > 0)
        {
            myRigidbody.AddForce(new Vector2(7, 0));
            // Flip the sprite to face right
            spriteRenderer.flipX = false;
        }
        else if (horizontalInput < 0)
        {
            myRigidbody.AddForce(new Vector2(-7, 0));
            // Flip the sprite to face left
            spriteRenderer.flipX = true;
        }
        if (horizontalInput > 0.01f || horizontalInput < -0.01f)
        {
            anim.SetBool("isWalking", true);
           // transform.position += new Vector3(1, 0, 0); transform.position.x - 0.1;
           // GetComponent<Animation>().Play("walking");
        } else
        {
            anim.SetBool("isWalking", false);
            //  GetComponent<Animation>().Play("idle");
        }
    }

    
}

