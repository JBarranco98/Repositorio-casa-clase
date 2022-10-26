using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioDimeParImpar : MonoBehaviour
{
    //En este ejercicio vamos a dar un rango de dos numeros y me va a decir cuales son paraes e impares entre ellos

    public int number1;
    public int number2;

    // Start is called before the first frame update
    void Start()
    {
        if (number1 < number2)
        {
            for (int i = number1; i <= number2; i++)
            {
            if (i % 2 == 0)
                {
                    Debug.Log(i + " this number is odd");
                }
                else
                {
                    Debug.Log(i + " this number is even");
                }
                
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
