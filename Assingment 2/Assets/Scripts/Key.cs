using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)

    { 
        Debug.Log("Triggered by:"+ other.name);

        if (other.CompareTag("Player"))
        {
            // Give player the key
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();
            if (inventory != null)
            {
                inventory.hasKey = true;
            }

            // Optionally destroy the key object
            Destroy(gameObject);
        }
    }
}
