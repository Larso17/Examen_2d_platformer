using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plr_shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootPos;
    [SerializeField] public int ammo = 10;
    public float bulletspeed = 500f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ammo > 0)
        {
            // Instantiate the bullet at the shoot position (which is based on the player's facing direction)
            GameObject Bullet = Instantiate(bullet, shootPos.position, Quaternion.identity);

            // Get the player's facing direction (flip the direction based on player's scale.x)
            float direction = transform.localScale.x; // If the player is facing left, it will be -1; if right, it will be 1

            // Apply force based on direction (left or right)
            Bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.right * direction * 600f);

        

            // Destroy bullet after 3 seconds
            Destroy(Bullet, 3f);

            ammo--;
            Debug.Log(ammo);
        }


        if (Input.GetKeyDown(KeyCode.R))
        {

        }

    }
    public void AddAmmo(int amount)
    {
        ammo += amount;
        Debug.Log("Ammo picked up. Current ammo: " + ammo);
    }
}
