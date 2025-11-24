using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill_player : MonoBehaviour
{
    public int damage = 1;  // Damage the enemy deals

    public float damageInterval = 1f; // Time interval between damage application
    private float timer = 0f;

    private void Update()
    {
        timer += Time.deltaTime; // Increment the timer by the frame time (delta time)
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Only apply damage every 1 second
            if (timer >= damageInterval)
            {
                // Assuming the player has a Plr_health script attached
                Plr_health playerHealth = collision.gameObject.GetComponent<Plr_health>();

                if (playerHealth != null)
                {
                    playerHealth.TakeDamage(damage);

                }

                timer = 0f; // Reset the timer after applying damage
            }
        }
    }
}