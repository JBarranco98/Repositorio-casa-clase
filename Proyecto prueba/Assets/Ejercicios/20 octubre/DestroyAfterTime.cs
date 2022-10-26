using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float timeTodestroy = 2;

    // Start is called before the first frame update
    private void Start()
    {
        Destroy(gameObject, timeTodestroy);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}