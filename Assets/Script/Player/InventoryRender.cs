using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryRender : MonoBehaviour
{
    public Image[] slots;

    private void Start()
    {
        Render();
        
    }

    public void Render()
    {
        for (int i = 0; i < Inventory.inventory.Count; i++)
        {
            slots[i].sprite = Inventory.inventory[i].icon;
        }
    }
}
