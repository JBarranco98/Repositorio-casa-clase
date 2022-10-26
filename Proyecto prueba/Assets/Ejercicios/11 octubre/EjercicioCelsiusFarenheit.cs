using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCelsiusFarenheit : MonoBehaviour
{
    // En este ejercicio vamos a pasar de celsius a farenheit

    public float degreesCelsius;
    float farenheit; 

    // Start is called before the first frame update
    void Start()
    {
        farenheit = (degreesCelsius * 9 / 5) + 32;
        Debug.Log(degreesCelsius + " degrees Celsius are " + farenheit + " degrees farenheit");
            
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
