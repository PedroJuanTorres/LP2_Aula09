using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepAI : AnimalsAI 
{
    protected override void Move()
    {
        Debug.Log("Sheep Moving!");
    }
    protected override void TryEat()
    {
        Debug.Log("Sheep Eating!");
    }
    protected override void TryReproduce()
    {
        Debug.Log("Sheep Reproducing!");
    }
}
