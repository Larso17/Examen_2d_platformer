using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_walk : MonoBehaviour
{

    public float moveSpeed = 2f;
    public Transform groundCheck;
    public Transform wallCheck;
    public float checkDistance = 0.1f;
    public LayerMask groundLayer;
    public LayerMask wallLayer;

    private bool movingRight = true;
    private Rigidbody2D rb;
    private float flipCooldown = 0.2f;
    private float lastFlipTime = 0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Patrol();
        Debug.DrawRay(groundCheck.position, Vector2.down * checkDistance, Color.red);

    }
    private void Patrol()
    {
        if (Time.time - lastFlipTime >= flipCooldown)
        {
            RaycastHit2D groundHit = Physics2D.Raycast(groundCheck.position, Vector2.down, checkDistance, groundLayer);
            RaycastHit2D wallHit = Physics2D.Raycast(wallCheck.position, Vector2.right * (movingRight ? 1f : -1f), checkDistance, wallLayer);  // Only check for wall collisions

            if (!groundHit.collider || wallHit.collider)
            {
                Flip();
            }
        }

        rb.velocity = new Vector2(movingRight ? moveSpeed : -moveSpeed, rb.velocity.y);
    }

    private void Flip()
    {
        movingRight = !movingRight;
        lastFlipTime = Time.time;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

}
