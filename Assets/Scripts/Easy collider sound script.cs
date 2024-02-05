using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easycollidersoundscript : MonoBehaviour
{
    public AudioSource basket;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            
            basket.enabled = true;
        }
        else
        {
            basket.enabled = false;
        }
    }
}
