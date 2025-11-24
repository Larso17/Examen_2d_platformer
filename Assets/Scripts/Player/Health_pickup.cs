using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_pickup : MonoBehaviour
{
    public int giveHealth = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Plr_health playerHealth = other.GetComponent<Plr_health>();
            if (playerHealth != null && playerHealth.Health < playerHealth.maxHealth)
            {
                playerHealth.Heal(giveHealth); // Assuming you have a Heal(int amount) method
                Destroy(gameObject); // Destroy the pickup after use
            }
        }
    }


}
