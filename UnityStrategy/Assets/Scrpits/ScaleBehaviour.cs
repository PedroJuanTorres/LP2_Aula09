using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBehaviour : MonoBehaviour , IAnimateBehaviour
{
    private float scale = 0;
    public void Animate()
    {
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f) + Mathf.Abs(Mathf.Cos(scale)) * Vector3.one;

        scale += 0.01f;
    }
}
