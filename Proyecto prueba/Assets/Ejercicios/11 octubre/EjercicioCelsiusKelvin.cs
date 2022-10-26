using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCelsiusKelvin : MonoBehaviour
{
    // En este ejercicio vamos a convertir grados centigrados a kelvin.

    public float degreescelsius;
    float kelvin;
    // Start is called before the first frame update
    void Start()
    {
        kelvin = degreescelsius + 273;
        Debug.Log(degreescelsius + " degrees Celsius are " + kelvin + " kelvin.");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
