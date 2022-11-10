using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioFactorial : MonoBehaviour
{
    // En este ejercicio vamos a calcular el factorial de un numero

    public int number1;
    int result = 1;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = number1; i > 0; i--)
        {
            result *= i;
        }
        Debug.Log(result);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
