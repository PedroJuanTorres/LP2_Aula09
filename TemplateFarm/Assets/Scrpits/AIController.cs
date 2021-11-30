using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    private IEnumerable<AnimalsAI> animalsAIs;

    private IEnumerator TurnTime()
    {
        while(true)
        {
            YieldInstruction wfs = new WaitForSeconds(2);
            foreach(AnimalsAI animal in animalsAIs)
            {
                animal.TakeTurn();
            }
            yield return wfs;
        }
    }

    private void Awake()
    {
        animalsAIs = new AnimalsAI[] {new SheepAI(), new WolvesAI(), new RabbitAI()};
    }

    private void Start()
    {
        StartCoroutine(TurnTime());
    }
}
