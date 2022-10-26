using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpObject : MonoBehaviour
{
    public Transform objectToMove;
    public Transform initialPosition, finalPosition;

    public float timeToLerp = 5;
    private float elapsedTime = 0;

    public AnimationCurve lerpCurve;

    // Update is called once per frame
    private void Update()
    {
        elapsedTime += Time.deltaTime;
        float lerpPercentage = elapsedTime / timeToLerp;
        objectToMove.position = Vector3.Lerp(initialPosition.position, finalPosition.position, lerpCurve.Evaluate(lerpPercentage));

        if (elapsedTime > timeToLerp)
        {
            elapsedTime = 0;
            swap();
        }
    }

    public void swap()
    {
        Transform temp = initialPosition;
        initialPosition = finalPosition;
        finalPosition = temp;
    }
}