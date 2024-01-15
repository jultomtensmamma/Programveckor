using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    
}

