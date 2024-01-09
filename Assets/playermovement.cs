using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour

   
{
    Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
  private void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.AddForce(new Vector3(0, 10, 0), ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.AddForce(new Vector3(5, 0, 0));

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.AddForce(new Vector3(-5, 0, 0));
        }


    }
}
