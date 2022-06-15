using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "PickItem", menuName = "Item/PickItem", order = 1)]
public class Item : ScriptableObject
{
    public GameObject prefab;
    public Sprite icon;
}
