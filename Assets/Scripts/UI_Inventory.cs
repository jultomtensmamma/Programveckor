using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    private ItemHolder itemHolder;
    private Transform itemSlotContainer;
    private Transform itemSlotTemplate;
    private void Awake()
    {
        itemSlotContainer = transform.Find("itemSlotContainer");
        itemSlotTemplate = itemSlotContainer.Find("itemSlotTemplate");

    }
    public void SetItemHolder(ItemHolder itemHolder)
    {
        this.itemHolder = itemHolder;

    }
    //Vart Item Ikonen dyker upp
    private void RefreshItemHolderItems(){
        int X = 0;
        int y = 0;
        float itemSlotCellsize = 30f;
        foreach (Item.ItemType item in itemHolder.GetItemList()){

           RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
           itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(X * itemSlotCellsize, y * itemSlotCellsize);
            X++;
            if (X > 4){
                X = 0;
                y++;
            }
        }
    }
}
