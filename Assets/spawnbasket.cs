using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawnbasket : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer sr;
    public AudioSource basket;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.enabled = false;
    }

    // Update is called once per frame
   private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            sr.enabled = true;
            basket.enabled = true;
        }
        else
        {
            basket.enabled = false;
        }
    }
}
