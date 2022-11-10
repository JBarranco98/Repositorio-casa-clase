using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioNumerosPrimos : MonoBehaviour
{
    //En este ejercicio vamos a decir si un numero es primo o no

    public int number1;
    int result;


    // Start is called before the first frame update
    void Start()
    {
        if (number1 % 2 == 0)
        {
            Debug.Log("This number is prime");
        }
        else
        {
            if (result != 0)
            {
                for (int i = number1; number1 % i == 0 ; i--)
                {
                    Debug.Log("This number is prime");
                }
            }
            else
            {
                Debug.Log("This number is not prime");
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
