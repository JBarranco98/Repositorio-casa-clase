using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioBucleFor : MonoBehaviour
{

    //Bucle for

    int number;

    // Start is called before the first frame update
    void Start()
    {
        for (number = 0; number <= 100; number++ )
        {
         if ( number % 2 == 0)
            {
                Debug.Log(number);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
