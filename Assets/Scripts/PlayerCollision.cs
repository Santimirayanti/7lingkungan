using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public BirdMovement birdMovement;
    public GameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            birdMovement.enabled = false;

            gameManager.EndGame();
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Score")
        {
            gameManager.AddScore();
        }
    }
}
