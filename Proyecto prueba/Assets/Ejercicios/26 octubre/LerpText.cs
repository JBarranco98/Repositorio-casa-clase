using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpText : MonoBehaviour
{
    public float a = 0;
    public float b = 10;

    public float timeToLerp = 5;
    private float timeElapse = 0;

    public float lerpValue;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        timeElapse += Time.deltaTime;
        float lerpPercentage = timeElapse / timeToLerp;

        lerpValue = Mathf.Lerp(a, b, lerpPercentage);
    }
}