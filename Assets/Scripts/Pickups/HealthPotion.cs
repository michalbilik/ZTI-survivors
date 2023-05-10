using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Pickup, ICollectible
{
    // The amount of health to restore when this item is collected
    public int healthToRestore;
    public AudioClip healSound;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayHealSound()
    {
        audioSource.PlayOneShot(healSound, 0.7F);
    }


    public void Collect()
    {
        PlayerStats player = FindObjectOfType<PlayerStats>();
        audioSource.PlayOneShot(healSound, 0.7f);
        player.RestoreHealth(healthToRestore);
    }
}