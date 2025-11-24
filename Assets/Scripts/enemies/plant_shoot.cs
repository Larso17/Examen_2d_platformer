using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant_shoot : MonoBehaviour
{
    public GameObject bulletPrefab;      // Bullet prefab to shoot
    public Transform shootingPoint;      // Point from where the bullet is shot
    public float shootInterval = 2f;     // Time between each shot
    public float bulletSpeed = 7f;       // Speed of the bullet

    private float timeSinceLastShot = 0f;

    void Update()
    {
        timeSinceLastShot += Time.deltaTime;

        if (timeSinceLastShot >= shootInterval)
        {
            Shoot();
            timeSinceLastShot = 0f;
        }
    }

    void Shoot()
    {


        if (bulletPrefab && shootingPoint)
        {
            GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, Quaternion.identity);

            float direction = transform.localScale.x > 0 ? -1f : 1f; // flipped

            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = new Vector2(direction * bulletSpeed, 0f);
            }

            if (direction < 0)
            {
                Vector3 bulletScale = bullet.transform.localScale;
                bulletScale.x *= -1;
                bullet.transform.localScale = bulletScale;
            }
        }
    }
}
