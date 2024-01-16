using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hedgehogmovement : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    [SerializeField]
    GameObject deer;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("hopp");
            myRigidbody.AddForce(new Vector3(0, 5, 0), ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {

        Vector2 direction = deer.transform.position - transform.position;
        float horizontalInput = direction.x;
        

        if (horizontalInput > 0)
        {
            
            // Flip the sprite to face right
            spriteRenderer.flipX = true;
        }
        else if (horizontalInput < 0)
        {
            
            // Flip the sprite to face left
            spriteRenderer.flipX = false;
        }
        
        myRigidbody.AddForce(direction);
    }
}
