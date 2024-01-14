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
<<<<<<< HEAD
        transform.position = new Vector3(0, 2, 0);
=======
        transform.position = new Vector3(0, -26, 0);
>>>>>>> 89694be4c29db82d264e089a41d9a6233cd2c1b1
    }

    // Update is called once per frame
    private void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
       {
            myRigidbody.AddForce(new Vector3(0, 5, 0), ForceMode2D.Impulse);
       }
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.AddForce(new Vector3(6, 0, 0));

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.AddForce(new Vector3(-6, 0, 0));
        }

    }
}
