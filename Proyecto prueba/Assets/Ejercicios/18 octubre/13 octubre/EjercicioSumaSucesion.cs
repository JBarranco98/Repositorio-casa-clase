using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioSumaSucesion : MonoBehaviour
{
    //En este ejercicio vamos a hacer que se sumen todos los numeros de una sucesion

    public int number1;
    public int number2;
   

    // Start is called before the first frame update
    void Start()
    {
        int result = 0;
                       if (number1 < number2)
        {
            for (int i = number1; i <= number2 ; i++)
            {
                result += i;  
            }
            Debug.Log(result);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
