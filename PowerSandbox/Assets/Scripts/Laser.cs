using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : Superpower
{
    [SerializeField]
    private float damage = 0;

    public override void Activate()
    {
        DealDamage(damage);
        LightMyFire();
    }
}
