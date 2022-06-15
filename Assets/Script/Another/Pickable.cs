using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : InteractiveItem
{
    [SerializeField] Item Item;
    public Item Pick()
    {
        if (Inventory.inventory.Count !< Inventory.invSize) DestroyItem();
            return Item;
    }

    public override void Use()
    {
        getItem();
    }

    void getItem()
    {
        Inventory.AddItem(Pick());
    }

    public void DestroyItem()
    {
        Destroy(gameObject);
    }
    
}
