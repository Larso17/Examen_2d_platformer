using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    public Plr_health playerHealth; // Assign this in the inspector

    void Update()
    {
        if (playerHealth != null && playerHealth.Health <= 0)
        {
            RestartLevel();
        }
    }

    void RestartLevel()
    {
        Debug.Log("Player died Restarting level...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
