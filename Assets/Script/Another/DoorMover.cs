using UnityEngine;
public class DoorMover : MonoBehaviour
{
    [SerializeField] private Transform targetPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Player player))
        {
            GameObject.FindObjectOfType<Player>().SetPosition(targetPoint.position);
        }
    }
}
