using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoost : Superpower
{
    [SerializeField]
    private float health = 0;
    [SerializeField]
    private float percentage = 0;

    public override void Activate()
    {
        Heal(health);
        BoostSpeed(percentage);
    }
}
