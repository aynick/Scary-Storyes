using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    private Transform playerBody;
    private float xRotation;
    [SerializeField] [Range(1,1000)] private float sens;

    private void Start()
    {
        playerBody = transform.parent;
    }

    public void CamRotate()
    {
        var xMouse = Input.GetAxis("Mouse X") * sens * Time.fixedDeltaTime;
        var yMouse = Input.GetAxis("Mouse Y") * sens * Time.fixedDeltaTime;
        xRotation -= yMouse;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        playerBody.Rotate(Vector3.up * (xMouse));
    }
}
