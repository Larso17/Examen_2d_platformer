using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    public Plr_health playerHealth; // Drag your player here in the inspector
    public TextMeshProUGUI healthText; // Or use TMP_Text if you're fancy

    void Update()
    {
        if (playerHealth != null && healthText != null)
        {
            healthText.text = "X" + playerHealth.Health.ToString("0"); // Optional: Format without decimal
        }
    }
}
