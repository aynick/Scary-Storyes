using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tumba : InteractiveItem
{
    private Animator _animator;
    private bool isOpen = false;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public override void Use()
    {
        OpenClose();
    }

    void OpenClose()
    {
        if (isOpen)
        {
           _animator.SetBool("Open",isOpen);
            isOpen = false;
        }
        else
        { 
            _animator.SetBool("Open",isOpen);
            isOpen = true;
        }
    }
}