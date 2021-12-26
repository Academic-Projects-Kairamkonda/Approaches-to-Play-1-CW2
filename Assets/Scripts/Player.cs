using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ATP1_CW2
{
    public enum PlayerState
    {
        idle,
        walk,
        run,
        jump,
    }

    public class Player : MonoBehaviour
    {
        Animator animator;
        Rigidbody2D rigidBody;

        public PlayerState playerState;

        private void Awake()
        {
            animator = GetComponent<Animator>();
            rigidBody = GetComponent<Rigidbody2D>();
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
            if(playerState==PlayerState.walk)
                Movement();
        }

        public void Movement()
        {
            float x = Input.GetAxis("Horizontal");
            rigidBody.velocity = new Vector2(x + 2.5f, 0);
            Debug.Log("X:"+ x);
            animator.SetFloat("move", x);
        }
    }
}