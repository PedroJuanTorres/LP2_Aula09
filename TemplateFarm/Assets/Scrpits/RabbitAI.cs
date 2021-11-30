using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitAI : AnimalsAI
{
    protected override void Move()
    {
        Debug.Log("Rabbit Moving!");
    }
    protected override void TryEat()
    {
        Debug.Log("Rabbit Eating!");
    }
    protected override void TryReproduce()
    {
        Debug.Log("Rabbit Reproducing!");
    }
}
