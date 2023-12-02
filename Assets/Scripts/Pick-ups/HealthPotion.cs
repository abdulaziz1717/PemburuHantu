using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Pickup, ICollectible
{
    // The amount of health to restore when this item is collected
    public int healthToRestore;

    public void Collect()
    {
        PlayerStats stats = FindObjectOfType<PlayerStats>();
        stats.RestoreHealth(healthToRestore);
    }
}
