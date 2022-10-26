using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioEdad : MonoBehaviour
{

    // En este ejercicio al introducir un numero, nos dira si es mayor o menor de edad 

    public int age = 0;


    // Start is called before the first frame update
    void Start()
    {
        if (age < 18)
        {
            Debug.Log("You don´t met the age requirements");
        }
        else
        {
            Debug.Log("You met the age requirements");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
