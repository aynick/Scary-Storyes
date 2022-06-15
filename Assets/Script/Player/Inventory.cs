using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Inventory
{
    public static List<Item> inventory = new List<Item>();

    public static int invSize = 7;
    static public void AddItem(Item item)
    {
        if (inventory.Count < invSize)
        {
            inventory.Add(item);
        }
    }
}
