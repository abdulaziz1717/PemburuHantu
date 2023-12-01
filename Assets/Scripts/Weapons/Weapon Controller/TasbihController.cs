using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasbihController : WeaponController
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void Attack()
    {
        base.Attack();
        GameObject spawnedTasbih = Instantiate(prefab);
        spawnedTasbih.transform.position = transform.position; //Assign the position to be the same as this object which is parented to the player
        spawnedTasbih.transform.parent = transform;
    }
}
