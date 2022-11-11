using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigletonExample : MonoBehaviour
{
    public static SigletonExample Instance;

    public int currentScore = 5;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}