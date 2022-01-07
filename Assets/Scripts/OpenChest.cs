using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = this.GetComponent<Animator>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("Open", true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("Open", false);
    }
}
