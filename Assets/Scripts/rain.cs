using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rain : MonoBehaviour
{
   
    [SerializeField]
    GameObject rain1;
    [SerializeField]
    GameObject rain2;
    [SerializeField]
    GameObject rain3;
    [SerializeField]
    GameObject rain4;
    [SerializeField]
    GameObject rain5;
    [SerializeField]
    GameObject rain6;
    [SerializeField]
    GameObject rain7;
    [SerializeField]
    GameObject rain8;
    [SerializeField]
    GameObject rain9;
    [SerializeField]
    GameObject rain10;
    [SerializeField]
    GameObject rain11;
    [SerializeField]
    GameObject rain12;
    [SerializeField]
    GameObject rain13;
    [SerializeField]
    GameObject rain14;
    [SerializeField]
    GameObject rain15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < 1000;i++)
        {
            if(i == 5)
            {
                continue;
            }
                
                Instantiate(rain1, transform.position + new Vector3(-7, 6, 0), Quaternion.identity);
                Instantiate(rain2, transform.position + new Vector3(-5, 4, 0), Quaternion.identity);
                Instantiate(rain3, transform.position + new Vector3(-3, 6, 0), Quaternion.identity);
                Instantiate(rain4, transform.position + new Vector3(-1, 4, 0), Quaternion.identity);
                Instantiate(rain5, transform.position + new Vector3(1, 6, 0), Quaternion.identity);
                Instantiate(rain6, transform.position + new Vector3(3, 4, 0), Quaternion.identity);
                Instantiate(rain7, transform.position + new Vector3(5, 6, 0), Quaternion.identity);
                Instantiate(rain8, transform.position + new Vector3(7, 4, 0), Quaternion.identity);
                Instantiate(rain9, transform.position + new Vector3(9, 6, 0), Quaternion.identity);
                Instantiate(rain10, transform.position + new Vector3(11, 4, 0), Quaternion.identity);
            Instantiate(rain11, transform.position + new Vector3(-8, 6, 0), Quaternion.identity);
            Instantiate(rain12, transform.position + new Vector3(-4, 4, 0), Quaternion.identity);
            Instantiate(rain13, transform.position + new Vector3(2, 6, 0), Quaternion.identity);
            Instantiate(rain14, transform.position + new Vector3(6, 4, 0), Quaternion.identity);
            Instantiate(rain15, transform.position + new Vector3(4, 6, 0), Quaternion.identity);



        }


    }
}
