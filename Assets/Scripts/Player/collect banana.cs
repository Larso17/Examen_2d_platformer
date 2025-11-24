using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectbanana : MonoBehaviour
{
    public int bananasCollected = 0;  // Keep track of how many bananas were collected
    public int targetBananas = 1;     // Set the target number of bananas
    public GameObject ending;         // Reference to the ending GameObject

    void Start()
    {
        ending.SetActive(false); // Disable the ending initially
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Banana")) // If the object is tagged as "Banana"
        {
            bananasCollected++; // Increment the collected bananas
            Destroy(other.gameObject); // Destroy the collected banana
            CheckForEnding(); // Check if we should enable the ending
        }
    }

    void CheckForEnding()
    {
        if (bananasCollected >= targetBananas) // If the player has collected enough bananas
        {
            ending.SetActive(true); // Enable the ending
        }
    }
}
