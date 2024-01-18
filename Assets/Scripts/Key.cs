using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour{
    [SerializeField] private KeyType keyType;
   public enum KeyType{
        Berries,
        Mushroom,
        basket,

    }

    public KeyType GetKeyType()
    {

        return keyType;
    }
}
