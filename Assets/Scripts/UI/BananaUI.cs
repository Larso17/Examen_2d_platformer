using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BananaUI : MonoBehaviour
{
    public collectbanana collectbanana; // Reference to your collectbanana script
   
    public TMP_Text bananaText; // If using TextMeshPro

    void Update()
    {
        if (collectbanana != null && bananaText != null)
        {
            bananaText.text = ": " + collectbanana.bananasCollected+"/"+ collectbanana.targetBananas;
        }
    }
}
