using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ATP1_CW2
{
    public class Player : MonoBehaviour
    {
        Animator animator;
        Rigidbody2D rigidBody;
        SpriteRenderer spriteRenderer;

        private PlayerState playerState;

        private float moveSpeed=4f;

        public bool flip = false;

        private void Awake()
        {
            animator = GetComponent<Animator>();
            rigidBody = GetComponent<Rigidbody2D>();
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        void Start()
        {
            playerState = PlayerState.idle;
        }

        void Update()
        {

        }

        private void FixedUpdate()
        {
            Movement();
        }

        public void Movement()
        {
            float x = Input.GetAxis("Horizontal"); //Debug.Log("X:" + x);

            if(x<-0.1)
            {
                spriteRenderer.flipX = true;
            }
            else if(x>0.1)
            {
                spriteRenderer.flipX = false;
            }
            rigidBody.velocity = new Vector2(x* moveSpeed, rigidBody.velocity.y);

            Debug.Log(rigidBody.velocity);

            animator.SetFloat("move", Mathf.Abs(x));
        }
    }

    public enum PlayerState
    {
        idle,
        walk,
        run,
        jump,
    }
}