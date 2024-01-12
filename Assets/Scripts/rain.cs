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

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < 1000;i++)
        {
            if(i == 2)
            {
                continue;
            }
                
                Instantiate(rain1, transform.position + new Vector3(-7, 3, 0), Quaternion.identity);
                Instantiate(rain2, transform.position + new Vector3(-5, 2, 0), Quaternion.identity);
                Instantiate(rain3, transform.position + new Vector3(-3, 3, 0), Quaternion.identity);
                Instantiate(rain4, transform.position + new Vector3(-1, 2, 0), Quaternion.identity);
                Instantiate(rain5, transform.position + new Vector3(1, 3, 0), Quaternion.identity);
                Instantiate(rain6, transform.position + new Vector3(3, 2, 0), Quaternion.identity);
                Instantiate(rain7, transform.position + new Vector3(5, 3, 0), Quaternion.identity);
                Instantiate(rain8, transform.position + new Vector3(7, 2, 0), Quaternion.identity);
                Instantiate(rain9, transform.position + new Vector3(9, 3, 0), Quaternion.identity);
                Instantiate(rain10, transform.position + new Vector3(11, 2, 0), Quaternion.identity);

            
            
        }


    }
}
