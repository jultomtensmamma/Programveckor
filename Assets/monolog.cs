using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monolog : MonoBehaviour
{
    int number = 0;
    [SerializeField]
    GameObject Monolog1;
    [SerializeField]
    GameObject Monolog2;
    [SerializeField]
    GameObject Monolog3;
    [SerializeField]
    GameObject Monolog4;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&& number == 0)
        {
            Monolog1.SetActive(true);
            number += 1;
        }
        

        if (Input.GetKeyDown(KeyCode.W) && number == 1)
        {
            Monolog1.SetActive(false);
            Monolog2.SetActive(true);
            number += 1;
        }
        
        else if (Input.GetKeyDown(KeyCode.W) && number == 2)
        {
            Monolog2.SetActive(false);
            Monolog3.SetActive(true);
            number += 1;
        }
        else if (Input.GetKeyDown(KeyCode.W) && number == 3)
        {
            Monolog3.SetActive(false);
            Monolog4.SetActive(true);
            number += 1;
        }
        else if (Input.GetKeyDown(KeyCode.X) && number == 4)
        {
            Monolog4.SetActive(false);
           
            number += 0;
        }
    }
    
}
