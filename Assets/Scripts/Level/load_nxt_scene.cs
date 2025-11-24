using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_nxt_scene : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Optional: check for a tag if you only want a specific object to trigger it
        if (other.CompareTag("Player"))
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }
}
