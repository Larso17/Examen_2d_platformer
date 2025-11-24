using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AmmoUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ammoText; // Use Text for standard UI
    // [SerializeField] private TMP_Text ammoText; // Use this instead if using TMP

    [SerializeField] private Plr_shoot Shoot; // Reference to your weapon script

    void Update()
    {
        if (Shoot != null && ammoText != null)
        {
            ammoText.text = $": {Shoot.ammo}";
        }
    }

}
