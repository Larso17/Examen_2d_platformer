using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant_bullet : MonoBehaviour
{
    public int damage = 1;
    public float byebye = 2f;
    void Start()
    {
        // Start moving the bullet in a straight line
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, byebye);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        Plr_health playerHealth = collision.gameObject.GetComponent<Plr_health>();
        if (collision.gameObject.CompareTag("Player"))
        {
            playerHealth.Health -= damage;
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);           // Destroy the bullet on other collisions
        }
    }
}
