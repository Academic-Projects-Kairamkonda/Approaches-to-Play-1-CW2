using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ATP1_CW2
{
    public class GameData : MonoBehaviour
    {
        public Transform[] spawnPoints;

        public Checkpoint checkpoint;

        private Animator m_animator;

        private HeroKnight heroKnight;

        private void Awake()
        {
            m_animator = GetComponent<Animator>();
            heroKnight = GetComponent<HeroKnight>();
        }

        private void Start()
        {
            UpdatePlayerPosition();
        }

        private void UpdatePlayerPosition()
        {
            switch (checkpoint)
            {
                case Checkpoint.CheckpointOne:
                    this.transform.position = spawnPoints[0].transform.position;
                    break;

                case Checkpoint.CheckpointTwo:
                    this.transform.position = spawnPoints[1].transform.position;
                    break;

                default:
                    break;
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Checkpoint")
            {
                checkpoint = Checkpoint.CheckpointOne;
            }

            if (collision.gameObject.tag == "CheckpointTwo")
            {
                checkpoint = Checkpoint.CheckpointTwo;
            }

            if (collision.gameObject.tag == "Respawn")
            {
                UpdatePlayerPosition();
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Trap")
            {
                heroKnight.Death();
                heroKnight.enabled = false;
            }
        }

        private IEnumerator FreezeTime()
        {
            yield return new WaitForSeconds(2);
            Time.timeScale = 0;
        }
    }

    public enum Checkpoint
    {
        CheckpointOne,
        CheckpointTwo,
        CheckpointThree,
        CheckpointFour
    }
}