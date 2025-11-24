using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plr_health : MonoBehaviour
{
    public float Health =2;
    public float maxHealth = 2;
    // Start is called before the first frame update
    void Start()
    {
        Health = maxHealth;

    }
        public void TakeDamage(float amount)
    {
        Health -= amount;
        Health = Mathf.Max(Health, 0); // Clamp to min

    }
    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void Heal(int amount)
{
        Health += amount;
        Health = Mathf.Min(Health, maxHealth); // Clamp to max health

    }
}
