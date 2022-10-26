using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioPositivoNegativo : MonoBehaviour
{
    // En este ejercicio vamos a decir si un numero es positivo o negativo (excluyendo el 0)

    public int InputNumber = 0;


    // Start is called before the first frame update
    void Start()
    {
        if (InputNumber > 0)
        {
            Debug.Log("This number is positive");
        }
        else
        {
            Debug.Log("This number is negative");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
