    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PlayerMove : MonoBehaviour
    {
        
        [SerializeField]private float defaultSpeed;
        [SerializeField]private float ctrlSpeed;
        private float speed;
        [SerializeField]private float jumpHeight; 
        private float gravity = -9.8f; 
        private CharacterController _characterController; 
        [SerializeField]private Transform checkGround; 
        private bool isGround; 
        private float radius = 0.17f; 
        [SerializeField]private LayerMask ignoreMask; 
        private Vector3 velocity;
        private Vector3 ctrlScale;
        private Vector3 defaultScale;
        
        private void Start()
        {
            defaultScale = transform.localScale;
            ctrlScale = new Vector3(defaultScale.x, defaultScale.y / 2, defaultScale.z);
            _characterController = GetComponent<CharacterController>();
        }

        private void FixedUpdate()
        {
            GravityPhysic();
        }

        void GravityPhysic() 
        {
                 isGround = Physics.CheckSphere(checkGround.position, radius , ignoreMask);
                velocity.y += gravity * Time.fixedDeltaTime;
                _characterController.Move(velocity * Time.fixedDeltaTime);
                if (isGround && velocity.y < 0)
                {
                    velocity.y = -2f;
                }
        }

            public void SetPosition(Vector3 pos)
            {
                _characterController.enabled = false;
                transform.position = pos;
                _characterController.enabled = true;
            }


            public void OnCtrl()
            {
                transform.localScale = ctrlScale;
                speed = ctrlSpeed;
            }
            public void Walk()
            {
                var xMove = Input.GetAxis("Horizontal") * speed;
                var zMove = Input.GetAxis("Vertical") * speed;
                var targetPos = ((transform.right * xMove) + (transform.forward * zMove));
                _characterController.Move(targetPos * Time.fixedDeltaTime);
                if (!Input.GetKey(KeyCode.LeftControl))
                {
                    transform.localScale = defaultScale;
                    speed = defaultSpeed;
                }
            }
            public void Jump() 
            {
                if (isGround)
                {
                    velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
                }
            }
    }
