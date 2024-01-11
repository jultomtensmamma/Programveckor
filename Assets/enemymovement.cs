using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{

    Rigidbody myRigidbody;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void Fire(Vector3 direction)
    {
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.AddForce(direction, ForceMode.Impulse);
    }
    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        

        GameObject otherGameobject = collision.gameObject;
        player hitEnemy = otherGameobject.GetComponent<player>();
        if (hitEnemy != null)
        {
            hitEnemy.TakeDamage();
        }

        Destroy(gameObject);
    }

}
