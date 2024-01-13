using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemHolder : MonoBehaviour
{
    private List<Item.ItemType> itemList;

    private void Awake() {

        itemList = new List<Item.ItemType>();

    }
    public void AddItem(Item.ItemType itemType){
        Debug.Log("Added Item: " + itemType);
        itemList.Add(itemType);
    }
    public void RemoveItem(Item.ItemType itemType){
        itemList.Remove(itemType);
    }
    public bool ContainsItem(Item.ItemType itemType){

        return itemList.Contains(itemType);
    }
    private void OnTriggerEnter2D(Collider2D collider){
        Item item = collider.GetComponent<Item>();
        if(item != null){

            AddItem(item.GetItemType());
            Destroy(item.gameObject);
        }
        //Tests if the things you collided with is the right KeyDoor
        ItemDoor itemDoor = collider.GetComponent<ItemDoor>();
        if(itemDoor != null) {
           if(ContainsItem(itemDoor.GetItemType()));
            //Key in "inventory" to open the door
            RemoveItem(itemDoor.GetItemType());
            itemDoor.OpenDoor();
        }
    }
}
