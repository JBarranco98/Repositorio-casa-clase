using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioPar : MonoBehaviour
{
    //En este ejercicio vamos a decir si un numero es par o impar

    public int InputNumber = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        
        if (InputNumber % 2 == 0)
        {
            Debug.Log("The number is even");
        }
        else
        {
            Debug.Log("The number is odd");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
