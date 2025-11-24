using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enable_spikes : MonoBehaviour
{

    public GameObject spikes;
    // Start is called before the first frame update
    void Start()
    {
        spikes.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")){
            spikes.SetActive(true);
        }
    }
}
