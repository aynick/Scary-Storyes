
using UnityEngine;

public class Player : MonoBehaviour, IPlayerControll
{
    private PlayerMove _move;
    private CameraRotate _cameraRotate;

    private void Start()
    {
        _move = GetComponent<PlayerMove>();
        _cameraRotate = GetComponentInChildren<CameraRotate>();
    }


    public void Move()
    {
        _move.Walk();;
    }

    public void Jump()
    {
        _move.Jump();
    }

    public void OnCtrl()
    {
        _move.OnCtrl();;
    }

    public void CameraRotate()
    {
        _cameraRotate.CamRotate();
    }

    public void SetPosition(Vector3 pos)
    {
        _move.SetPosition(pos);
    }
    
    /// <summary>
    /// Save
    /// </summary>
    
    public void save()
    {
        SaveLoad.Save(transform.position);
    }
}