using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class enemy : MonoBehaviour
{
    float timer = 0;
    
    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField]
    GameObject Enemy1;
    [SerializeField]
    GameObject Enemy2;
    [SerializeField]
    GameObject Enemy3;
    [SerializeField]
    GameObject Enemy4;
    [SerializeField]
    GameObject Enemy5;
    [SerializeField]
    GameObject Enemy6;
    [SerializeField]
    GameObject Enemy7;
    [SerializeField]
    GameObject Enemy8;
    // Update is called once per frame
    public void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W))
        {
            GameObject Enemy1GameObject = Instantiate(Enemy1, transform.position + new Vector3(300, 300, 0), Quaternion.identity);
            enemymovement bulletComponent = Enemy1GameObject.GetComponent<enemymovement>();
            bulletComponent.Fire(new Vector3(10, 0, 0));
           
        }
        if (Input.GetKeyDown(KeyCode.W)&& timer > 1)
        {
            GameObject Enemy2GameObject = Instantiate(Enemy2, transform.position + new Vector3(300, 300, 0), Quaternion.identity);
            enemymovement bulletComponent = Enemy2GameObject.GetComponent<enemymovement>();
            bulletComponent.Fire(new Vector3(10, 0, 0));

        }
        if (Input.GetKeyDown(KeyCode.W) && timer > 2)
        {
            GameObject Enemy3GameObject = Instantiate(Enemy3, transform.position + new Vector3(300, 300, 0), Quaternion.identity);
            enemymovement bulletComponent = Enemy3GameObject.GetComponent<enemymovement>();
            bulletComponent.Fire(new Vector3(10, 0, 0));

        }
        if (Input.GetKeyDown(KeyCode.W) && timer > 3)
        {
            GameObject Enemy4GameObject = Instantiate(Enemy1, transform.position + new Vector3(300, 300, 0), Quaternion.identity);
            enemymovement bulletComponent = Enemy4GameObject.GetComponent<enemymovement>();
            bulletComponent.Fire(new Vector3(10, 0, 0));

        }
        if (Input.GetKeyDown(KeyCode.W) && timer > 4)
        {
            GameObject Enemy5GameObject = Instantiate(Enemy2, transform.position + new Vector3(300, 300, 0), Quaternion.identity);
            enemymovement bulletComponent = Enemy5GameObject.GetComponent<enemymovement>();
            bulletComponent.Fire(new Vector3(10, 0, 0));

        }
        if (Input.GetKeyDown(KeyCode.W) && timer > 5)
        {
            GameObject Enemy6GameObject = Instantiate(Enemy3, transform.position + new Vector3(300, 300, 0), Quaternion.identity);
            enemymovement bulletComponent = Enemy6GameObject.GetComponent<enemymovement>();
            bulletComponent.Fire(new Vector3(10, 0, 0));

        }
        if (Input.GetKeyDown(KeyCode.W) && timer > 6)
        {
            GameObject Enemy7GameObject = Instantiate(Enemy2, transform.position + new Vector3(300, 300, 0), Quaternion.identity);
            enemymovement bulletComponent = Enemy7GameObject.GetComponent<enemymovement>();
            bulletComponent.Fire(new Vector3(10, 0, 0));

        }
        if (Input.GetKeyDown(KeyCode.W) && timer > 7)
        {
            GameObject Enemy8GameObject = Instantiate(Enemy3, transform.position + new Vector3(300, 300, 0), Quaternion.identity);
            enemymovement bulletComponent = Enemy8GameObject.GetComponent<enemymovement>();
            bulletComponent.Fire(new Vector3(10, 0, 0));

        }
    }
    public void Fire(Vector3 direction)
    {
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.AddForce(direction, ForceMode.Impulse);
    }
}
