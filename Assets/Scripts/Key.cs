using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour{
    [SerializeField] private KeyType keyType;
    public AudioSource PickUpSound;
    //lista av inventory saker
    public enum KeyType{
        Berries,
        Berries2,
        Mushroom,
        Mushroom2,
        basket,

    }

    public KeyType GetKeyType()
    {

        return keyType;
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.tag == "Player")
        {
           
            PickUpSound.enabled = true;
        }
        else
        {
            PickUpSound.enabled = false;
        }

    }
}
