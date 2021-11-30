using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolvesAI : AnimalsAI
{
    protected override void SelectTarget() 
    {
        Debug.Log("Wolf Looking for sheep!");
    }

    protected override void Move()
    {
        Debug.Log("Wolf Moving!");
    }
    protected override void TryEat()
    {
        Debug.Log("Wolf Eating!");
    }
    protected override void TryReproduce()
    {
        Debug.Log("Wolf Reproducing!");
    }
}
