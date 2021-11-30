using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private IEnumerable<Superpower> powers;

    private IEnumerator PowersTime()
    {
        while(true)
        {
            YieldInstruction wfs = new WaitForSeconds(5);
            foreach (Superpower power in powers)
            {
                power.Activate();
            }
            yield return wfs;
        }
    }

    private void Awake()
    {
        powers = GetComponents<Superpower>();
    }

    private void Start()
    {
        StartCoroutine(PowersTime());
    }
}
