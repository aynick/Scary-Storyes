using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : InteractiveItem
{
    public override void Use()
    {
        DestroyObj();
    }

    void DestroyObj()
    {
        Destroy(gameObject);
    }
}
