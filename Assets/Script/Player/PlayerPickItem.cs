
using UnityEngine;

public class PlayerPickItem : MonoBehaviour
{
    [SerializeField] private InventoryRender _inventoryRender;
    [SerializeField] private GameObject pressE;
    [SerializeField] private Transform hand;
    void PickItem()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit,5)) 
        {
            pressE.SetActive(false);
            if (hit.collider.gameObject.TryGetComponent(out InteractiveItem interactiveItem))
            {
                pressE.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E)) 
                {
                    interactiveItem.Use();
                    _inventoryRender.Render();
                    pressE.SetActive(false);
                }
            }
        }
    }

    

    void SelectItem()
    {
        Item item;
        if (Input.GetKey(KeyCode.Alpha1))
        {
            item = Inventory.inventory[0]; 
            DestroyHandChild(); 
            Instantiate(item.prefab, hand.position, hand.rotation, hand);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            item = Inventory.inventory[1];
            DestroyHandChild(); 
            Instantiate(item.prefab, hand.position, hand.rotation, hand);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            item = Inventory.inventory[2]; 
            DestroyHandChild(); 
            Instantiate(item.prefab, hand.position, hand.rotation, hand);
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            item = Inventory.inventory[3]; 
            DestroyHandChild(); 
            Instantiate(item.prefab, hand.position, hand.rotation, hand);
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            item = Inventory.inventory[4]; 
            DestroyHandChild(); 
            Instantiate(item.prefab, hand.position, hand.rotation, hand);
        }
        if (Input.GetKey(KeyCode.Alpha6))
        { 
            item = Inventory.inventory[5]; 
            DestroyHandChild(); 
            Instantiate(item.prefab, hand.position, hand.rotation, hand);
        }
        if (Input.GetKey(KeyCode.Alpha7))
        {
            item = Inventory.inventory[6]; 
            DestroyHandChild(); 
            Instantiate(item.prefab, hand.position, hand.rotation, hand);
        }
    }

    void DestroyHandChild()
    {
        var count = hand.childCount;
        for (int j = 0; j < count; j++)
        {
            Destroy(hand.GetChild(j).gameObject);
        }
    }
    private void FixedUpdate()
    {
        PickItem();
        SelectItem();
    }
}
