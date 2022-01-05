using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ATP1_CW2
{
    public class GameData : MonoBehaviour
    {
        public Transform[] spawnPoints;

        public Checkpoint checkpoint;

        private void Start()
        {
            checkpoint = Checkpoint.CheckpointOne;
            UpdatePlayerPosition();
        }

        private void UpdatePlayerPosition()
        {
            switch (checkpoint)
            {
                case Checkpoint.CheckpointOne:
                   this.transform.position=spawnPoints[0].transform.position;
                    break;

                case Checkpoint.CheckpointTwo:
                    this.transform.position= spawnPoints[1].transform.position;
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

            if (collision.gameObject.tag=="CheckpointTwo")
            {
                checkpoint = Checkpoint.CheckpointTwo;
            }


            if(collision.gameObject.tag=="Respawn")
            {
                UpdatePlayerPosition();
            }
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