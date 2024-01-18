using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour{
    [SerializeField] private KeyType keyType;
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
}
