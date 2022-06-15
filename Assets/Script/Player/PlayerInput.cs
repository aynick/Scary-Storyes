using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Player _player;
    private IPlayerControll _playerControll;

    private void Start()
    {
        _playerControll = _player?.GetComponent<IPlayerControll>();
    }

    private void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)_playerControll.Move();
        if (Input.GetKey(KeyCode.Space)) _playerControll.Jump();
        if (Input.GetKey(KeyCode.LeftControl)) _playerControll.OnCtrl();
        if (Input.mousePosition != Vector3.zero) _playerControll.CameraRotate();
    }
}
