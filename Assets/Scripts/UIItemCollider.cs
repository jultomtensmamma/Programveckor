using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIItemCollider : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer sr;
    public AudioSource PickUpSound;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.enabled = false;


    }


    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            sr.enabled = true;
            PickUpSound.enabled = true;
        }
        else
        {
            PickUpSound.enabled = false;
        }

    }
   
}
