using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2_move : MonoBehaviour
{
    public Transform[] waypoints; // Array of waypoints
    public float moveSpeed = 3f; // Speed of movement
    public float waypointThreshold = 0.2f; // How close the enemy has to be to a waypoint to move to the next one

    private int currentWaypointIndex = 0;

    void Update()
    {
        if (waypoints.Length == 0) return;

        // Move the enemy towards the current waypoint
        MoveTowardsWaypoint();
    }

    void MoveTowardsWaypoint()
    {
        // Get the current waypoint
        Transform targetWaypoint = waypoints[currentWaypointIndex];

        // Move the enemy towards the waypoint
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, step);

        // Check if the enemy has reached the waypoint
        if (Vector3.Distance(transform.position, targetWaypoint.position) <= waypointThreshold)
        {
            // If so, switch to the next waypoint
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length; // Loops back to the first waypoint
        }
    }
}
