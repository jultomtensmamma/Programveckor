using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hedgehogmovement : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("hopp");
            myRigidbody.AddForce(new Vector3(0, 5, 0), ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.AddForce(new Vector3(6, 0, 0));
            print("höger");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.AddForce(new Vector3(-6, 0, 0));
            print("vänster");
        }
    }
}
