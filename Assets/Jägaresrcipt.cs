using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jägaresrcipt : MonoBehaviour

{
    // Start is called before the first frame update
    Rigidbody2D myRigidbody;
    void Start()
    {
        myRigidbody.GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.AddForce(new Vector3(15, 0, 0));
    }
}
