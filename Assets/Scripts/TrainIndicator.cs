using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainIndicator : MonoBehaviour
{
    public float detectionRadius = 5.0f; // Radius for detecting the player
    public Color warningColor = Color.red; // Color to indicate danger
    private Color originalColor; // Store the original color of the player
    private Renderer playerRenderer; // Reference to the player's Renderer component

    private void Start()
    {
        // Find the player by tag
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            playerRenderer = player.GetComponent<Renderer>();

            if (playerRenderer != null)
            {
                originalColor = playerRenderer.material.color;
            }
            else
            {
                Debug.LogError("Player does not have a Renderer component.");
            }
        }
        else
        {
            Debug.LogError("No GameObject with tag 'Player' found.");
        }
    }

    private void Update()
    {
        // Check if the player is within detection radius of this train
        Collider[] colliders = Physics.OverlapSphere(transform.position, detectionRadius);

        bool playerInRange = false;

        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Player"))
            {
                playerInRange = true;
                break;
            }
        }

        if (playerInRange)
        {
            // Change the player's color to indicate danger
            if (playerRenderer != null)
            {
                playerRenderer.material.color = warningColor;
            }
        }
        else
        {
            // Reset to original color when the player is out of range
            if (playerRenderer != null)
            {
                playerRenderer.material.color = originalColor;
            }
        }
    }
}