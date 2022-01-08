using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioBonus;
    public AudioClip audioClip;

    private void Awake()
    {
        animator = this.GetComponent<Animator>();
        audioBonus = this.GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("Open", true);
        audioBonus.PlayOneShot(audioClip);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("Open", false);
    }
}
