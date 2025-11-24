using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo_pickup : MonoBehaviour
{
    public int GiveAmmo = 5;  // Ammo to give when the pickup is collected

    // When the player enters the trigger zone
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object colliding with the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Access the SpawnBullet script on the player and add ammo
            Plr_shoot spawnBullet = other.GetComponent<Plr_shoot>();
            if (spawnBullet != null)
            {
                spawnBullet.AddAmmo(GiveAmmo);
            }

            // Destroy the ammo pickup object after it's collected
            Destroy(gameObject);
        }
    }
}
