using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour{
    [SerializeField] private ItemType itemType;
    public enum ItemType{
        RedKey,
        GreenKey,
        BlueKey,
        Berries,
    }
   
    
    
    public ItemType GetItemType()
    {

        return itemType;
    }
}
