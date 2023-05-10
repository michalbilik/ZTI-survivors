using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))    //If it gets too close to the player, destroy it. No need for any fancy code
        {
            Destroy(gameObject);
        }
    }
}